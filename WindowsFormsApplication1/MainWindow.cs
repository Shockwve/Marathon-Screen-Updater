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
    public enum CSVCOL_KEYS
    {
        SCHEDULED = 0,
        LENGTH,
        GAME,
        CATEGORY,
        RUNNER,
        RUNNER_PRONOUNS,
        HOST,
        HOST_PRONOUNS,
        COMMENTATOR_1,
        COMMENTATOR_2,
        GAME_CATEGORY_SYSTEM 
    }

    public partial class MainWindow : Form
    {
        private int currentLine = 0;
        private List<String> scheduleLines = new List<string>();
        private String workingDirectory = System.IO.Directory.GetCurrentDirectory() + "\\MarthonScreenUpdater";

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
            WriteToFiles();
        }

        private void LoadLineFromSchedule(int lineNum)
        {
            string information = scheduleLines.ElementAt<string>(lineNum).Replace("\"", "");
            string[] splitText = information.Split(';');

            /*runnerTextbox.Text = splitText[(int)CSVCOL_KEYS.RUNNER];
            runnerPronounsTextBox.Text = splitText[(int)CSVCOL_KEYS.RUNNER_PRONOUNS];

            gameTextBox.Text = splitText[(int)CSVCOL_KEYS.GAME];
            estTextbox.Text = splitText[(int)CSVCOL_KEYS.LENGTH];
            categoryTextbox.Text = splitText[(int)CSVCOL_KEYS.CATEGORY];

            hostTextBox.Text = splitText[(int)CSVCOL_KEYS.HOST];
            hostPronounsTextBox.Text = splitText[(int)CSVCOL_KEYS.HOST_PRONOUNS];

            comms1TextBox.Text = splitText[(int)CSVCOL_KEYS.COMMENTATOR_1];
            comms2TextBox.Text = splitText[(int)CSVCOL_KEYS.COMMENTATOR_2];

            comms1PronounsTextBox.Text = "";
            comms2PronounsTextBox.Text = "";*/
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
            
        }
    }
}
