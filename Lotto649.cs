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
    public partial class Lotto649 : Form
    {
        static string dir = @".\files\";
        static string path = dir + "Lotto.txt";
        static string[] header;

        public Lotto649()
        {
            InitializeComponent();
        }

        private void btGenerate_Click(object sender, EventArgs e)
        {
            Int32[] arr_Num = new Int32[7]; //array to receive numbers
            GenerateRandom obj = new GenerateRandom(); //object to access class
            string print = ""; //string to print;

            //Generating Unique Numbers to Text Box
            arr_Num = obj.GenerateArrayUnique(7, 1, 49);
            obj.SaveTofile("649", arr_Num); //saving to file

            for (int i = 0; i < arr_Num.Length; i++)
            {
                print = print + arr_Num[i] + "\r\n";
            }

            bxNums.Text = print;

            //Generating Unique Numbers to Label
            arr_Num = obj.GenerateArrayUnique(7, 0, 9); //overwriting arr_Num with 7 num for label, from 0 to 9

            print = "";
            for (int i = 0; i < arr_Num.Length; i++)
            {
                print = print + arr_Num[i] + " "; //creating string to print with a space between numbs
            }
            lbNums.Text = print; //printing in label
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want\nto quit the application\nLotto 649?", "Exit ?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btRead_Click(object sender, EventArgs e)
        {
            header = new string[3];
            header[0] = "Type";
            header[1] = "Date and Time (Gen)";
            header[2] = "Generated Numbers";

            DisplayFile obj = new DisplayFile(path, header);
            obj.ShowDialog();
        }
    }
}
