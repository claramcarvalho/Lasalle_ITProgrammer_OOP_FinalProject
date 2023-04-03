using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class frm_Dashboard : Form
    {
        public frm_Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                Application.Exit();
            }          
        }

        private void frm_Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void bt_Exchange_Click(object sender, EventArgs e)
        {
            MoneyConv obj = new MoneyConv();

            obj.ShowDialog();
        }

        private void bt_Lotto_Max_Click(object sender, EventArgs e)
        {
            LottoMax obj = new LottoMax();

            obj.ShowDialog();
        }

        private void bt_Lotto_649_Click(object sender, EventArgs e)
        {
            Lotto649 obj = new Lotto649();

            obj.ShowDialog();
        }

        private void bt_Temp_Conv_Click(object sender, EventArgs e)
        {
            TempConv obj = new TempConv();

            obj.ShowDialog();
        }

        private void btIPv4_Click(object sender, EventArgs e)
        {
            IP4_Validator obj = new IP4_Validator();

            obj.ShowDialog();
        }

        private void btCalc_Click(object sender, EventArgs e)
        {
            Calculator obj = new Calculator();

            obj.ShowDialog();
        }
    }
}
