using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;


namespace Final_Project
{
    public partial class IP4_Validator : Form
    {
        string dir = @".\files\";
        DateTime begin;

        public IP4_Validator()
        {
            InitializeComponent();
        }

        private void IP4_Validator_Load(object sender, EventArgs e)
        {
            begin = DateTime.Now;

            lbDate.Text = "Today: " + begin.ToShortDateString();

            if (!Directory.Exists(dir))
            { 
                Directory.CreateDirectory(dir);
                MessageBox.Show(dir + "\nThe directory has been created.");
            }
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want\nto quit the application\nIPv4 Validator?", "Exit ?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DateTime end = DateTime.Now;
                TimeSpan timeInForm = end - begin;

                MessageBox.Show("You have been using this application for: " +
                                timeInForm.ToString("mm") + " minutes and " +
                                timeInForm.ToString("ss") + " seconds.");
                this.Close();
            }
        }

        private void bt_Validate_Click(object sender, EventArgs e)
        {
            Regex rx = new Regex(@"^([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])(\.)([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])(\.)([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])(\.)([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$");

            if (rx.IsMatch(txIP.Text))
            {
                MessageBox.Show(txIP.Text +
                                "\r\nThe IP is correct", "Valid IP", MessageBoxButtons.OK);
                SaveToFile(txIP.Text);
            }
            else
            {
                MessageBox.Show(txIP.Text +
                                "\r\nThe IP must have 4 bytes." +
                                "\r\nEach byte must be an integer between 0 and 255, without leading zeros." +
                                "\r\nBytes must be separated by a dot (.).", "ErrorP", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void bt_Reset_Click(object sender, EventArgs e)
        {
            txIP.Text = "";
        }

        private void SaveToFile(string ip)
        {
            string b_full_path = dir + "binary_IPv4.txt";
            
            FileStream file = new FileStream(b_full_path, FileMode.Append, FileAccess.Write);
            BinaryWriter new_data = new BinaryWriter(file);

            DateTime date = DateTime.Now;

            new_data.Write(ip);
            new_data.Write(date.ToString());

            new_data.Close();
            file.Close();
        }
    }
}
