using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{

    public partial class MoneyConv : Form
    {
        DateTime begin, end;

        public static string dir = @".\files\";
        public static string path = dir + "MoneyConv.txt";
        public static string[] header;

        public MoneyConv()
        {
            InitializeComponent();
        }

        private void MoneyConv_Load(object sender, EventArgs e)
        {
            rdBtFromCAD.Select();
            rdBtToCAD.Select();
            begin = DateTime.Now;


            if (!Directory.Exists(path))
            { Directory.CreateDirectory(dir); }
        }

        private void bt_Conv_Click(object sender, EventArgs e)
        {
            Double read_amount;
            Int16 read_currency;
            ConvertM money;

            Regex rx = new Regex(@"^([0-9]){1,}((\.)([0-9]){1,2})?$");
            string read_Box;

            read_Box = txBox_CurrIN.Text;
            
            if(!rx.IsMatch(read_Box))
            {
                MessageBox.Show("Input only numbers!" +
                                "\nInput must have a maximum of 2 decimals." +
                                "\nThe decimal separator must be a '.' .",
                                "Wrong format!!!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txBox_CurrIN.Text = "0";
                txBox_CurrIN.Focus();
            }
            else
            {
                if (rdBtFromCAD.Checked)
                { read_currency = 1; }
                else if (rdBtFromUSD.Checked)
                { read_currency = 2; }
                else if (rdBtFromEUR.Checked)
                { read_currency = 3; }
                else if (rdBtFromGBP.Checked)
                { read_currency = 4; }
                else
                { read_currency = 5; }

                read_amount = Convert.ToDouble(txBox_CurrIN.Text);
                money = new ConvertM(read_amount, read_currency);

                if (rdBtToCAD.Checked)
                { money.To_CAD(); }
                else if (rdBtToUSD.Checked)
                { money.To_USD(); }
                else if (rdBtToEUR.Checked)
                { money.To_EUR(); }
                else if (rdBtToGBP.Checked)
                { money.To_GBP(); }
                else
                { money.To_BRL(); }

                txBox_CurrOUT.Text = money.M_out.Amount.ToString();
                SaveToFile(money);
            }
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want\nto quit the application\nMoney Exchange?", "Exit ?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                end = DateTime.Now;
                TimeSpan timeInForm = end - begin;

                MessageBox.Show("You have been using this application for: " + 
                                timeInForm.ToString("mm") + " minutes and " +
                                timeInForm.ToString("ss") + " seconds.");
                this.Close();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
         
        }

        private void rdBtFromCAD_CheckedChanged(object sender, EventArgs e)
        {
            txBox_CurrOUT.Text = "";
        }

        private void rdBtFromUSD_CheckedChanged(object sender, EventArgs e)
        {
            txBox_CurrOUT.Text = "";
        }

        private void rdBtFromEUR_CheckedChanged(object sender, EventArgs e)
        {
            txBox_CurrOUT.Text = "";
        }

        private void rdBtFromGBP_CheckedChanged(object sender, EventArgs e)
        {
            txBox_CurrOUT.Text = "";
        }

        private void rdBtFromBRL_CheckedChanged(object sender, EventArgs e)
        {
            txBox_CurrOUT.Text = "";
        }

        private void rdBtToCAD_CheckedChanged(object sender, EventArgs e)
        {
            txBox_CurrOUT.Text = "";
        }

        private void rdBtToUSD_CheckedChanged(object sender, EventArgs e)
        {
            txBox_CurrOUT.Text = "";
        }

        private void rdBtToEUR_CheckedChanged(object sender, EventArgs e)
        {
            txBox_CurrOUT.Text = "";
        }

        private void rdBtToGBP_CheckedChanged(object sender, EventArgs e)
        {
            txBox_CurrOUT.Text = "";
        }

        private void rdBtToBRL_CheckedChanged(object sender, EventArgs e)
        {
            txBox_CurrOUT.Text = "";
        }

        private void bt_ReadFile_Click(object sender, EventArgs e)
        {
            header = new string[2];
            header[0] = "Conversion (From/To)";
            header[1] = "Date and Time";
            
            DisplayFile obj = new DisplayFile(path,header);
            obj.ShowDialog();
        }

        private void txBox_CurrIN_TextChanged(object sender, EventArgs e)
        {
            txBox_CurrOUT.Text = "";
        }

        private void SaveToFile(ConvertM money)
        {
            // opening/creating file to write

            DateTime date_now = DateTime.Now;

            FileStream file = new FileStream(path, FileMode.Append, FileAccess.Write);
            StreamWriter new_line = new StreamWriter(file);

            new_line.Write(money.M_in.Amount + " " + money.M_in.CurrencyString() + " = " + money.M_out.Amount + " " + money.M_out.CurrencyString() + "; ");
            new_line.WriteLine(date_now.ToString("yyyy/MM/dd HH:mm:ss"));

            new_line.Close();
            file.Close();
        }
    }

    internal class Money
    {
        private Double amount;
        private Int16 currency;

        public Double Amount
        {
            set { amount = value; }
            get { return amount; }
        }

        public Int16 Currency
        {
            set { currency = value; }
            get { return currency; }
        }

        public Money()
        {
            Amount = 0;
            Currency = 0;
        }

        public Money(Double amount, Int16 currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public string CurrencyString()
        {
            string curr;
            switch (Currency)
            {
                case 1:
                    curr="CAD";
                    break;
                case 2:
                    curr = "USD";
                    break;
                case 3:
                    curr = "EUR";
                    break;
                case 4:
                    curr = "GBP";
                    break;
                case 5:
                    curr = "BRL";
                    break;
                default:
                    curr = "NO CURRENCY";
                    break;
            }
            return curr;
        }
    }

    internal class ConvertM
    {
        private Money m_in, m_out;

        public Money M_in
        {
            set { m_in = value; }
            get { return m_in; }
        }

        public Money M_out
        {
            set { m_out = value; }
            get { return m_out; }
        }

        public ConvertM()
        {
            M_in = new Money(0,0);
            M_out = new Money(0,0);
        }

        public ConvertM(Double amount, Int16 currency)
        {
            M_in = new Money(amount, currency);
            M_out = new Money(0, 0);
        }

        public void To_CAD ()
        {
            M_out.Currency = 1; //currency 1 = CAD
            switch (M_in.Currency)
            {
                case 1: //Money In is in CAD
                    M_out = M_in;
                    break;
                case 2: //Money In is in USD
                    M_out.Amount = M_in.Amount * 1.3799; //100 USD = 137.99 CAD 15/03/2023
                    break;
                case 3: //Money In is in EUR
                    M_out.Amount = M_in.Amount * 1.4553; //100 EUR = 145.53 CAD 15/03/2023
                    break;
                case 4: //Money In is in GBP
                    M_out.Amount = M_in.Amount * 1.6585; //100 GBP = 165.85 CAD 15/03/2023
                    break;
                case 5: //Money In is in BRL
                    M_out.Amount = M_in.Amount * 0.2591; //100 BRL = 25.91 CAD 15/03/2023
                    break;
            }
        }
        public void To_USD()
        {
            M_out.Currency = 2; //currency 2 = USD
            switch (M_in.Currency)
            {
                case 1: //Money In is in CAD
                    M_out.Amount = M_in.Amount * 0.7244; //100 CAD = 72.44 USD 15/03/2023
                    break;
                case 2: //Money In is in USD
                    M_out = M_in;
                    break;
                case 3: //Money In is in EUR
                    M_out.Amount = M_in.Amount * 1.0542; //100 EUR = 105.42 USD 15/03/2023
                    break;
                case 4: //Money In is in GBP
                    M_out.Amount = M_in.Amount * 1.2018; //100 GBP = 120.18 USD 15/03/2023
                    break;
                case 5: //Money In is in BRL
                    M_out.Amount = M_in.Amount * 0.1879; //100 BRL = 18.79 USD 15/03/2023
                    break;
            }
        }

        public void To_EUR()
        {
            M_out.Currency = 3; //currency 3 = EUR
            switch (M_in.Currency)
            {
                case 1: //Money In is in CAD
                    M_out.Amount = M_in.Amount * 0.6871; //100 CAD = 68.71 EUR 15/03/2023
                    break;
                case 2: //Money In is in USD
                    M_out.Amount = M_in.Amount * 0.9485; //100 USD = 94.85 EUR 15/03/2023
                    break;
                case 3: //Money In is in EUR
                    M_out = M_in;
                    break;
                case 4: //Money In is in GBP
                    M_out.Amount = M_in.Amount * 1.14; //100 GBP = 114.00 EUR 15/03/2023
                    break;
                case 5: //Money In is in BRL
                    M_out.Amount = M_in.Amount * 0.1782; //100 BRL = 17.82 EUR 15/03/2023
                    break;
            }
        }

        public void To_GBP()
        {
            M_out.Currency = 4; //currency 4 = GBP
            switch (M_in.Currency)
            {
                case 1: //Money In is in CAD
                    M_out.Amount = M_in.Amount * 0.6024; //100 CAD = 60.24 GBP 15/03/2023
                    break;
                case 2: //Money In is in USD
                    M_out.Amount = M_in.Amount * 0.8317; //100 USD = 83.17 GBP 15/03/2023
                    break;
                case 3: //Money In is in EUR
                    M_out.Amount = M_in.Amount * 0.8764; //100 EUR = 87.64 GBP 15/03/2023
                    break;
                case 4: //Money In is in GBP
                    M_out = M_in;
                    break;
                case 5: //Money In is in BRL
                    M_out.Amount = M_in.Amount * 0.1563; //100 BRL = 15.63 GBP 15/03/2023
                    break;
            }
        }

        public void To_BRL()
        {
            M_out.Currency = 5; //currency 5 = BRL
            switch (M_in.Currency)
            {
                case 1: //Money In is in CAD
                    M_out.Amount = M_in.Amount * 3.8541; //100 CAD = 385.41 BRL 15/03/2023
                    break;
                case 2: //Money In is in USD
                    M_out.Amount = M_in.Amount * 5.3192; //100 USD = 531.92 BRL 15/03/2023
                    break;
                case 3: //Money In is in EUR
                    M_out.Amount = M_in.Amount * 5.6064; //100 EUR = 560.64 BRL 15/03/2023
                    break;
                case 4: //Money In is in GBP
                    M_out.Amount = M_in.Amount * 6.3956; //100 GBP = 639.56 BRL 15/03/2023
                    break;
                case 5: //Money In is in BRL
                    M_out = M_in;
                    break;
            }
        }

        
    }
}
