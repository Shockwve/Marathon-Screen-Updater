using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MainWindow : Form
    {
        private int currentLine = 0;
        private int currentX = 12;
        private int currentY = 15;
        private List<String> scheduleLines = new List<string>();
        private String workingDirectory = System.IO.Directory.GetCurrentDirectory() + "\\MarthonScreenUpdater";
        private String host = "";

        public MainWindow()
        {
            InitializeComponent();
            CreateFolder();
            UpdateOnScreenInformation();
        }

        private void CreateFolder()
        {
            if (!Directory.Exists(workingDirectory))
            {
                Directory.CreateDirectory(workingDirectory);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateOnScreenInformation();
        }

        private void UpdateOnScreenInformation()
        {
            string runner = runnerTextbox.Text;
            string game = gameTextBox.Text;
            string estimate = estTextbox.Text;
            string category = categoryTextbox.Text;

            File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\info.txt", runner + "\n\n" + game + "\n\n" + estimate + "\n\n" + category);
            WriteToFiles();
        }

        private void LoadLineFromSchedule(int lineNum)
        {
            string information = scheduleLines.ElementAt<string>(lineNum).Replace("\"", "");
            string[] splitText = information.Split(';');

            runnerTextbox.Text = splitText[3];

            gameTextBox.Text = splitText[2].Split('-')[0];
            estTextbox.Text = splitText[1];
            categoryTextbox.Text = splitText[2].Split('-')[1];
            
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            if (!CheckForLoadedSchedule())
            {
                return;
            }

            currentLine--;

            if(currentLine < 0)
            {
                currentLine = scheduleLines.Count - 1;
            }

            LoadLineFromSchedule(currentLine);
            UpdateOnScreenInformation();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (!CheckForLoadedSchedule())
            {
                return;
            }

            currentLine++;

            if (currentLine == scheduleLines.Count)
            {
                currentLine = 0;   
            }

            LoadLineFromSchedule(currentLine);
            UpdateOnScreenInformation();
        }

        private bool CheckForLoadedSchedule()
        {
            if (scheduleLines.Count == 0)
            {
                MessageBox.Show("Load the schedule first before attempting to seek!");
                return false;
            }

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Choose the downloaded Horaro schedule (.csv)";

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                scheduleLocationTextbox.Text = dialog.FileName;

                scheduleLines = File.ReadAllLines(scheduleLocationTextbox.Text).ToList<string>();
                scheduleLines.RemoveAt(0);
            }


        }

        private void WriteToFiles()
        {
            File.WriteAllText(workingDirectory + "\\runner.txt", runnerTextbox.Text);
            File.WriteAllText(workingDirectory + "\\category.txt", categoryTextbox.Text);
            File.WriteAllText(workingDirectory + "\\time.txt", estTextbox.Text);
            File.WriteAllText(workingDirectory + "\\game.txt", gameTextBox.Text);
            File.WriteAllText(workingDirectory + "\\host.txt", host);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
