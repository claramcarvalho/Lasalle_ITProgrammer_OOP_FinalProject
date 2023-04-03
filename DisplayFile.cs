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

namespace Final_Project
{
    public partial class DisplayFile : Form
    {
        
        public DisplayFile(string path, string[] head)
        {
            InitializeComponent();

            int lastSlashPosition = path.LastIndexOf(@"\");
            string name_of_file = path.Substring(lastSlashPosition+1);
            this.Text = "Content of File: " + name_of_file + " - Clara Carvalho";

            try
            {
                FileStream file = new FileStream(path, FileMode.Open);
                StreamReader new_line = new StreamReader(file);

                //MessageBox.Show("This is the path: " + path);

                string textToDisplay = "";
                string read_row;
                string[] formatted_row;

                //header
                foreach (string cell in head)
                {
                    textToDisplay = textToDisplay + cell + "\t";
                }
                textToDisplay = textToDisplay + "\r\n";

                //going through file
                while (new_line.Peek() != -1)
                {
                    read_row = new_line.ReadLine(); //getting a line
                    formatted_row = read_row.Split(';'); //splitting
                    foreach (string data in formatted_row) //going through data
                    {
                        textToDisplay = textToDisplay + data.Trim() + "\t";
                    }
                    textToDisplay = textToDisplay + "\r\n";
                }

                txbx_ContentFile.Text = textToDisplay;
                txbx_ContentFile.Enabled = false;

                file.Close();
            }
            catch
            {
                MessageBox.Show("The file path could not found:\n" + path);
            }
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DisplayFile_Load(object sender, EventArgs e)
        {

        }
    }
}
