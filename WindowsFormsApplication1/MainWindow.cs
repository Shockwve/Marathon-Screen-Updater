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

using Newtonsoft.Json;

namespace WindowsFormsApplication1
{
    public partial class MainWindow : Form
    {
        private int currentLine = 0;
        private int curLabelX = 12;
        private int curLabelY = 15;
        private int curTextBoxX = 73;
        private int curTextBoxY = 12;
        private string scheduleLines;
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
            /*string information = scheduleLines.ElementAt<string>(lineNum).Replace("\"", "");
            string[] splitText = information.Split(';');

            runnerTextbox.Text = splitText[3];

            gameTextBox.Text = splitText[2].Split('-')[0];
            estTextbox.Text = splitText[1];
            categoryTextbox.Text = splitText[2].Split('-')[1];*/
            
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
                currentLine = 0;//scheduleLines.Count - 1;
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

            LoadLineFromSchedule(currentLine);
            UpdateOnScreenInformation();
        }

        private bool CheckForLoadedSchedule()
        {
            if (!scheduleLocationTextbox.Text.Equals("") || !(scheduleLocationTextbox.Text == null))
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

                scheduleLines = File.ReadAllLines(scheduleLocationTextbox.Text).ToString();
            }

            var test = JsonConvert.DeserializeObject<HoraroResponse>(scheduleLines);

            createAllFormOptions();
        }

        private void createAllFormOptions()
        {
            int difY = 26;

            //for (int i = 0; i <= 5; i)
        }

        private void WriteToFiles()
        {
            File.WriteAllText(workingDirectory + "\\runner.txt", runnerTextbox.Text);
            File.WriteAllText(workingDirectory + "\\category.txt", categoryTextbox.Text);
            File.WriteAllText(workingDirectory + "\\time.txt", estTextbox.Text);
            File.WriteAllText(workingDirectory + "\\game.txt", gameTextBox.Text);
            File.WriteAllText(workingDirectory + "\\host.txt", host);
        }
    }

    public class HoraroResponse
    {
        private Meta meta;
        private Schedule schedule;
        private Event evnt;
        private HiddenColumns h_cols;
        private Columns cols;
    }

    public class Meta
    {
        private string exported;
        private string hint;
        private string api;
        private string apilink; 
    }
    
        public class Schedule
     {
        private string name;
        private string slug;
        private string timezone;
        private string start;
        private int start_t;
        private string website;
        private string twitter;
        private string fastestfurs;
        private string description;
        private string PT05M;
        private int setup_t;
        private string updated;
        private string url;
        
    }

    public class Columns
    {
        private string[] columns;
    }

    public class HiddenColumns
    {
        private string[] h_columns;
    }

    public class Event
    {
        private string name;
        private string slug;
    }
    public class Items
    {
        public string id;
        public string displayName;
        public string name;
        public string slug;
        public string imageUrl;
    }
}
