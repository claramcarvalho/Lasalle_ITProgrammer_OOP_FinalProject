using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class TempConv : Form
    {
        static string dir = @".\files\";
        static string path = dir + "TempConv.txt";
        DateTime date;
        public static string[] header;

        public TempConv()
        {
            InitializeComponent();
        }

        private void rdFtoC_CheckedChanged(object sender, EventArgs e)
        {
            lb1.Text = "F";
            lb2.Text = "C";
            txIn.Text = "";
            txOut.Text = "";
            lbMessage.Text = "";
        }

        private void rdCtoF_CheckedChanged(object sender, EventArgs e)
        {
            lb1.Text = "C";
            lb2.Text = "F";
            txIn.Text = "";
            txOut.Text = "";
            lbMessage.Text = "";
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want\nto quit the application\nTemperatura Conversion?", "Exit ?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void bt_Conv_Click(object sender, EventArgs e)
        {
            Temperature tempRead;
            string unit;

            if (rdCtoF.Checked)
            {
                unit = "C";
            }
            else
            {
                unit = "F";
            }

            try
            {
                tempRead = new Temperature(Convert.ToDouble(txIn.Text), unit);
                
                //changing color
                if (tempRead.TempCelcius < 10)
                { lbMessage.ForeColor = Color.Blue; }
                else if (tempRead.TempCelcius < 35)
                { lbMessage.ForeColor = Color.Green; }
                else
                { lbMessage.ForeColor = Color.Red; }

                if (rdCtoF.Checked)
                {
                    txOut.Text = tempRead.TempFahr.ToString();             
                    lbMessage.Text = tempRead.Message;
                    WriteToFile(tempRead, "C");
                }
                else
                {
                    txOut.Text = tempRead.TempCelcius.ToString();
                    lbMessage.Text = tempRead.Message;
                    WriteToFile(tempRead, "F");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Input only numbers!" +
                                "\nThe decimal separator must be a '.' .\n" + error.Message,
                                "Wrong format!!!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txIn.Text = "";
                txOut.Text = "";
            }
            
        }

        private void txIn_TextChanged(object sender, EventArgs e)
        {
            txOut.Text = "";
            lbMessage.Text = "";
        }

        private void TempConv_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
                MessageBox.Show(dir + "\nThe directory has been created.");
            }
        }

        private void WriteToFile(Temperature temp, string order)
        {           
            FileStream file = new FileStream(path, FileMode.Append, FileAccess.Write);
            StreamWriter new_line = new StreamWriter(file);

            date = DateTime.Now;

            if (order == "C")
            { new_line.Write(temp.TempCelcius + " C = " + temp.TempFahr + " F" + ";"); }
            else 
            { new_line.Write(temp.TempFahr + " F = " + temp.TempCelcius + " C" + ";"); }
            new_line.Write(date.ToString() + ";");
            new_line.WriteLine(temp.Message);

            new_line.Close();
            file.Close();
        }

        private void bt_ReadFile_Click(object sender, EventArgs e)
        {
            header = new string[3];
            header[0] = "Temp Conversion";
            header[1] = "Conv. Date and Time";
            header[2] = "Message";

            DisplayFile obj = new DisplayFile(path, header);
            obj.ShowDialog();
        }
    }

    public class Temperature
    {
        private Double tempCelcius;

        private Double tempFahr;

        private string message;

        public Double TempCelcius
        {
            set { tempCelcius = value; }
            get { return tempCelcius; }
        }
        public Double TempFahr
        {
            set { tempFahr = value; }
            get { return tempFahr; }
        }

        public string Message
        {
            set { message = value; }
            get { return message; }
        }

        public Temperature()
        {
            TempCelcius = -40;
            TempFahr = -40;
        }

        public Temperature(Double temp, string unit)
        {
            if (unit.ToUpper() == "C")
            {
                TempCelcius = temp;
                TempFahr = Math.Round(((TempCelcius * 9 / 5) + 32),2);
                Message = FindMessage();
            }
            else
            {
                TempFahr = temp;
                TempCelcius = Math.Round(((TempFahr - 32) * 5 / 9),2);
                Message = FindMessage();
            }
        }

        public string FindMessage ()
        {
            string mess;

            switch(tempCelcius)
            {
                case 100:
                    mess = "Water boils";
                    break;
                case 40:
                    mess = "Hot Bath";
                    break;
                case 37:
                    mess = "Body Temperature";
                    break;
                case 30:
                    mess = "Beach Weather";
                    break;
                case 10:
                    mess = "Cool Day";
                    break;
                case 0:
                    mess = "Freezing point of water";
                    break;
                case -40:
                    mess = "Extremely Cold Day\r\n(and the same number!)";
                    break;
                default:
                    if (tempCelcius > 18 && tempCelcius < 27)
                    {
                        mess = "Room Temperature";
                    }
                    else
                    {
                        if(tempCelcius>-40 && tempCelcius < -10)
                        {
                            mess = "Very Cold Day";
                        }
                        else
                        {
                            mess = "";
                        }
                    }
                    break;
            }                    
            return mess;
        }
    }
}
