using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace HW16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //_______________________
        // global variables
        //string UserPathInput;
        //string UserExtensionInput;
        //string[] Files;
        string UserStringInput;
        //________________________
        private void PathLabel_Click(object sender, EventArgs e)
        {
            string UserPathInput = PathLabel.Text;
            string UserExtensionInput = ExtensionDropbox.Text;
            string [] Files = Directory.GetFiles(UserPathInput, "*" + UserExtensionInput);

            for (int i = 0; i < Files.Length; i++)
            {
                ResultBox.Items.Add(Files[i]);
            }
        }
        
        private void SearchBttn_Click(object sender, EventArgs e)
        {
            string UserPathInput = Pathbox.Text;
            string UserStringInput = StringBox.Text;
            string UserExtensionInput = ExtensionDropbox.Text;
            try
            {
                string [] Files = Directory.GetFiles(UserPathInput, "*" + UserExtensionInput);

                foreach (var File in Files)
                {
                    var result = searchFile(File.ToString(), UserPathInput);

                    if (result)
                        ResultBox.Items.Add(File.ToString());
                }

                if (Files.Count() == 0)

                    ResultBox.Items.Add("No File Found");
                string LogMsg = "No File Found";
                WriteLog(LogMsg);

            }
            catch (Exception exp)
            {
                MessageBox.Show("Error =  " + exp.Message);

            }
        }
        public void WriteLog(string LogMsg)
        {
            FileStream LogFile = new FileStream("Log.txt", FileMode.Append, FileAccess.Write);
            StreamWriter SwLog = new StreamWriter(LogFile);
            DateTime Now = DateTime.Now;
            SwLog.WriteLine($"{Now}, {LogMsg}");
            SwLog.Close();
        }
        private void Clearbttn_Click(object sender, EventArgs e)
        {
            Pathbox.Text = string.Empty;
            ExtensionDropbox.Text = string.Empty;
            StringBox.Text = string.Empty;
            ResultBox.Items.Clear();
            string LogMsg = "Fields Are Cleared";
            WriteLog(LogMsg);
        }
        private bool searchFile(string fileName, string searchString)
        {
            bool stringFound = false;
            //open file
            FileStream file = new FileStream(fileName, FileMode.Open);
            StreamReader sr = new StreamReader(file);
            try {
                while (!sr.EndOfStream)
                {
                    //Read one line at a time
                    var line = sr.ReadLine();
                    //Examine each line to see if it contains searchString
                    if (line.ToUpper().Contains(UserStringInput.ToUpper()))
                    {
                        stringFound = true;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error =  " + ex.Message);
                string LogMsg = "Error =  " + ex.Message;
            }
            finally
            { 
            sr.Close();
            }
            return stringFound;
        }

        private void OnExit(object sender, FormClosedEventArgs e)
        {
            string LogMsg = "process end";
            WriteLog(LogMsg);
        }

        private void OnLoad(object sender, EventArgs e)
        {
            string LogMsg = "process Start";
            WriteLog(LogMsg);
        }
    }

}
