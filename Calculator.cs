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
    public partial class Calculator : Form
    {
        Calc operation = new Calc();
        Boolean flag = false;
        string directory, path;

        public Calculator()
        {
            InitializeComponent();
        }

        private void bt_1_Click(object sender, EventArgs e)
        {
            string text = txbx_Prompt.Text;
            string operationtx;

            if (flag == true) //a result was the last thing shown and user clicks on a number
            {
                operation.Clear();
                txbx_Prompt.Text = "1";

                operationtx = "1";
                flag = false;
            }
            else
            {
                if (text == "0")
                {
                    txbx_Prompt.Text = "1";
                }
                else
                {
                    text = text + "1";
                    txbx_Prompt.Text = text;
                }

                operationtx = txbx_Operation.Text;
                operationtx = operationtx + "1";
            }

            txbx_Operation.Text = operationtx;
        }
        

        private void bt_Dot_Click(object sender, EventArgs e)
        {
            string text = txbx_Prompt.Text;
            string operationtx = txbx_Operation.Text;


            if (!text.EndsWith("."))
            {
                text = text + ".";
                operationtx = operationtx + ".";
            }
            txbx_Prompt.Text = text;
            txbx_Operation.Text = operationtx;
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            txbx_Prompt.Text = "0";
            txbx_Prompt.Focus();

            directory = @".\files\";
            path = directory + "Calculator.txt";

            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
                MessageBox.Show("Directory created:\n" + directory);
            }
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_2_Click(object sender, EventArgs e)
        {
            string text = txbx_Prompt.Text;
            string operationtx;

            if(flag == true) //a result was the last thing shown and user clicks on a number
            {
                operation.Clear();
                txbx_Prompt.Text = "2";

                operationtx = "2";
                flag = false;
            }
            else
            {
                if (text == "0")
                {
                    txbx_Prompt.Text = "2";
                }
                else
                {
                    text = text + "2";
                    txbx_Prompt.Text = text;
                }

                operationtx = txbx_Operation.Text;
                operationtx = operationtx + "2";
            }
            
            txbx_Operation.Text = operationtx;
        }

        private void bt_3_Click(object sender, EventArgs e)
        {
            string text = txbx_Prompt.Text;
            string operationtx;

            if (flag == true) //a result was the last thing shown and user clicks on a number
            {
                //if a result was sthe last thing displayed and the user clicks on a number, the operation will clear and begin from 0
                operation.Clear(); //clearing operation
                txbx_Prompt.Text = "3"; //writing just number 3 in Prompt

                operationtx = "3"; //text containing the whole operation receives JUST 3
                flag = false; //reinitializing the flag
            }
            else //a result was not the last thing shown
            {
                if (text == "0") //text from prompt is zero
                {
                    txbx_Prompt.Text = "3"; //prompt must be just 3
                }
                else
                {
                    text = text + "3"; //prompt should get what was written and add 3
                    txbx_Prompt.Text = text; //display in text box
                }

                operationtx = txbx_Operation.Text; 
                operationtx = operationtx + "3"; //text containing the whole operation receives ALSO number 3
            }

            txbx_Operation.Text = operationtx; //display the whole operation
        }

        private void bt_4_Click(object sender, EventArgs e)
        {
            string text = txbx_Prompt.Text;
            string operationtx;

            if (flag == true) 
            //a result was the last thing shown and user clicks on a number
            {
                //the operation will clear and begin from 0
                operation.Clear(); //clearing operation
                txbx_Prompt.Text = "4"; //writing just number 4 in Prompt

                operationtx = "4"; //text containing the whole operation receives JUST 4
                flag = false; //reinitializing the flag
            }
            else 
            //a result was not the last thing shown
            {
                if (text == "0") 
                //if the text in prompt is zero
                {
                    txbx_Prompt.Text = "4"; //prompt must be just 4
                }
                else
                //if text in promtp is something other than 0
                {
                    text = text + "4"; //prompt should get what was written and add 4
                    txbx_Prompt.Text = text; //display in text box
                }

                operationtx = txbx_Operation.Text;
                operationtx = operationtx + "4"; //text containing the whole operation receives ALSO number 4
            }

            txbx_Operation.Text = operationtx; //display the whole operation
        }

        private void bt_5_Click(object sender, EventArgs e)
        {
            string text = txbx_Prompt.Text;
            string operationtx;

            if (flag == true) //a result was the last thing shown and user clicks on a number
            {
                //if a result was sthe last thing displayed and the user clicks on a number, the operation will clear and begin from 0
                operation.Clear(); //clearing operation
                txbx_Prompt.Text = "5"; //writing just number 5 in Prompt

                operationtx = "5"; //text containing the whole operation receives JUST 5
                flag = false; //reinitializing the flag
            }
            else //a result was not the last thing shown
            {
                if (text == "0") //text from prompt is zero
                {
                    txbx_Prompt.Text = "5"; //prompt must be just 5
                }
                else
                {
                    text = text + "5"; //prompt should get what was written and add 5
                    txbx_Prompt.Text = text; //display in text box
                }

                operationtx = txbx_Operation.Text;
                operationtx = operationtx + "5"; //text containing the whole operation receives ALSO number 5
            }

            txbx_Operation.Text = operationtx; //display the whole operation
        }

        private void bt_6_Click(object sender, EventArgs e)
        {
            string text = txbx_Prompt.Text;
            string operationtx;

            if (flag == true) //a result was the last thing shown and user clicks on a number
            {
                //if a result was sthe last thing displayed and the user clicks on a number, the operation will clear and begin from 0
                operation.Clear(); //clearing operation
                txbx_Prompt.Text = "6"; //writing just number 6 in Prompt

                operationtx = "6"; //text containing the whole operation receives JUST 6
                flag = false; //reinitializing the flag
            }
            else //a result was not the last thing shown
            {
                if (text == "0") //text from prompt is zero
                {
                    txbx_Prompt.Text = "6"; //prompt must be just 6
                }
                else
                {
                    text = text + "6"; //prompt should get what was written and add 6
                    txbx_Prompt.Text = text; //display in text box
                }

                operationtx = txbx_Operation.Text;
                operationtx = operationtx + "6"; //text containing the whole operation receives ALSO number 6
            }

            txbx_Operation.Text = operationtx; //display the whole operation
        }

        private void bt_7_Click(object sender, EventArgs e)
        {
            string text = txbx_Prompt.Text;
            string operationtx;

            if (flag == true) //a result was the last thing shown and user clicks on a number
            {
                //if a result was sthe last thing displayed and the user clicks on a number, the operation will clear and begin from 0
                operation.Clear(); //clearing operation
                txbx_Prompt.Text = "7"; //writing just number 7 in Prompt

                operationtx = "7"; //text containing the whole operation receives JUST 7
                flag = false; //reinitializing the flag
            }
            else //a result was not the last thing shown
            {
                if (text == "0") //text from prompt is zero
                {
                    txbx_Prompt.Text = "7"; //prompt must be just 7
                }
                else
                {
                    text = text + "7"; //prompt should get what was written and add 7
                    txbx_Prompt.Text = text; //display in text box
                }

                operationtx = txbx_Operation.Text;
                operationtx = operationtx + "7"; //text containing the whole operation receives ALSO number 7
            }

            txbx_Operation.Text = operationtx; //display the whole operation
        }

        private void bt_8_Click(object sender, EventArgs e)
        {
            string text = txbx_Prompt.Text;
            string operationtx;

            if (flag == true) //a result was the last thing shown and user clicks on a number
            {
                //if a result was sthe last thing displayed and the user clicks on a number, the operation will clear and begin from 0
                operation.Clear(); //clearing operation
                txbx_Prompt.Text = "8"; //writing just number 8 in Prompt

                operationtx = "8"; //text containing the whole operation receives JUST 8
                flag = false; //reinitializing the flag
            }
            else //a result was not the last thing shown
            {
                if (text == "0") //text from prompt is zero
                {
                    txbx_Prompt.Text = "8"; //prompt must be just 8
                }
                else
                {
                    text = text + "8"; //prompt should get what was written and add 8
                    txbx_Prompt.Text = text; //display in text box
                }

                operationtx = txbx_Operation.Text;
                operationtx = operationtx + "8"; //text containing the whole operation receives ALSO number 6
            }

            txbx_Operation.Text = operationtx; //display the whole operation
        }

        private void bt_9_Click(object sender, EventArgs e)
        {
            string text = txbx_Prompt.Text;
            string operationtx;

            if (flag == true) //a result was the last thing shown and user clicks on a number
            {
                //if a result was sthe last thing displayed and the user clicks on a number, the operation will clear and begin from 0
                operation.Clear(); //clearing operation
                txbx_Prompt.Text = "9"; //writing just number 6 in Prompt

                operationtx = "9"; //text containing the whole operation receives JUST 9
                flag = false; //reinitializing the flag
            }
            else //a result was not the last thing shown
            {
                if (text == "0") //text from prompt is zero
                {
                    txbx_Prompt.Text = "9"; //prompt must be just 9
                }
                else
                {
                    text = text + "9"; //prompt should get what was written and add 9
                    txbx_Prompt.Text = text; //display in text box
                }

                operationtx = txbx_Operation.Text;
                operationtx = operationtx + "9"; //text containing the whole operation receives ALSO number 9
            }

            txbx_Operation.Text = operationtx; //display the whole operation
        }

        private void bt_0_Click(object sender, EventArgs e)
        {
            string text = txbx_Prompt.Text;
            string operationtx;

            if (flag == true) //a result was the last thing shown and user clicks on a number
            {
                //if a result was sthe last thing displayed and the user clicks on a number, the operation will clear and begin from 0
                operation.Clear(); //clearing operation
                txbx_Prompt.Text = "0"; //writing just number 0 in Prompt

                operationtx = ""; //text containing the whole operation receives JUST 0
                flag = false; //reinitializing the flag
            }
            else //a result was not the last thing shown
            {
                if (text == "0") //text from prompt is zero
                {
                    txbx_Prompt.Text = "0"; //prompt must be just 0
                }
                else
                {
                    text = text + "0"; //prompt should get what was written and add 0
                    txbx_Prompt.Text = text; //display in text box
                }

                operationtx = txbx_Operation.Text;
                operationtx = operationtx + "0"; //text containing the whole operation receives ALSO number 0
            }

            txbx_Operation.Text = operationtx; //display the whole operation
        }

        private void bt_Clear_Click(object sender, EventArgs e)
        {
            txbx_Prompt.Text = "0";
            txbx_Prompt.Focus();
            txbx_Operation.Text = "";
            operation.Clear();
        }

        private void bt_Sum_Click(object sender, EventArgs e)
        {
            decimal DisplayValue;

            try
            {
                DisplayValue = Convert.ToDecimal(txbx_Prompt.Text);

                //calling add method
                
                if(operation.Op != null)
                {
                    MessageBox.Show("Please finish an operation before starting another one.\n" +
                                    "To finish and save your operation, click on '='.\n\n" +
                                    "You can always start from scratch without saving your results by clicking on Clear.\n\n" +
                                    "If you already have your result, please:\n" +
                                    "Click on any number to start a new operation\n" +
                                    "OR\n" +
                                    "Click on Clear.");
                }
                else
                {
                    operation.Add(DisplayValue);

                    string operationtx = txbx_Operation.Text;
                    operationtx = operationtx + "+";
                    txbx_Operation.Text = operationtx;

                    //setting prompt text box to 0 - reinitialize
                    txbx_Prompt.Text = "0";
                    flag = false;
                }
                
                
            }
            catch (Exception error)
            {
                MessageBox.Show("The value could not be converted to a Decimal value!\n"
                                + error.Message,
                                "Error!!!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void bt_Equal_Click(object sender, EventArgs e)
        {
            decimal DisplayValue;
            FileStream file = new FileStream(path, FileMode.Append, FileAccess.Write);
            
            try
            {
                DisplayValue = Convert.ToDecimal(txbx_Prompt.Text);

                string operationtx = txbx_Operation.Text;
                operationtx = operationtx + "=";

                try
                {
                    operation.Equals(DisplayValue);

                    txbx_Prompt.Text = operation.CurrentValue.ToString();

                    operationtx = operationtx + operation.CurrentValue.ToString();
                    txbx_Operation.Text = operationtx;

                    StreamWriter new_line = new StreamWriter(file);
                    new_line.WriteLine(operationtx);
                    new_line.Close();

                    flag = true;
                }
                catch(Exception error2)
                {
                    MessageBox.Show("It is impossible dto divide a number by ZERO!\n" +
                                    error2.Message);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("The value could not be converted to a Decimal value!\n"
                                + error.Message,
                                "Error!!!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

            file.Close();
        }

        private void bt_Sub_Click(object sender, EventArgs e)
        {
            decimal DisplayValue;

            try
            {
                DisplayValue = Convert.ToDecimal(txbx_Prompt.Text);

                if (operation.Op != null)
                {
                    MessageBox.Show("Please finish an operation before starting another one.\n" +
                                    "To finish and save your operation, click on '='.\n\n" +
                                    "You can always start from scratch without saving your results by clicking on Clear.\n\n" +
                                    "If you already have your result, please:\n" +
                                    "Click on any number to start a new operation\n" +
                                    "OR\n" +
                                    "Click on Clear.");
                }
                else
                {
                    operation.Subtract(DisplayValue);

                    string operationtx = txbx_Operation.Text;
                    operationtx = operationtx + "-";
                    txbx_Operation.Text = operationtx;

                    //setting prompt text box to 0 - reinitialize
                    txbx_Prompt.Text = "0";
                    flag = false;
                }

                
            }
            catch (Exception error)
            {
                MessageBox.Show("The value could not be converted to a Decimal value!\n"
                                + error.Message,
                                "Error!!!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void bt_Mul_Click(object sender, EventArgs e)
        {
            decimal DisplayValue;

            try
            {
                DisplayValue = Convert.ToDecimal(txbx_Prompt.Text);

                if (operation.Op != null)
                {
                    MessageBox.Show("Please finish an operation before starting another one.\n" +
                                    "To finish and save your operation, click on '='.\n\n" +
                                    "You can always start from scratch without saving your results by clicking on Clear.\n\n" +
                                    "If you already have your result, please:\n" +
                                    "Click on any number to start a new operation\n" +
                                    "OR\n" +
                                    "Click on Clear.");
                }
                else
                {
                    operation.Multiply(DisplayValue);

                    string operationtx = txbx_Operation.Text;
                    operationtx = operationtx + "*";
                    txbx_Operation.Text = operationtx;

                    //setting prompt text box to 0 - reinitialize
                    txbx_Prompt.Text = "0";
                    flag = false;
                }


            }
            catch (Exception error)
            {
                MessageBox.Show("The value could not be converted to a Decimal value!\n"
                                + error.Message,
                                "Error!!!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void bt_Div_Click(object sender, EventArgs e)
        {
            decimal DisplayValue;

            try
            {
                DisplayValue = Convert.ToDecimal(txbx_Prompt.Text);

                if (operation.Op != null)
                {
                    MessageBox.Show("Please finish an operation before starting another one.\n" +
                                    "To finish and save your operation, click on '='.\n\n" +
                                    "You can always start from scratch without saving your results by clicking on Clear.\n\n" +
                                    "If you already have your result, please:\n" +
                                    "Click on any number to start a new operation\n" +
                                    "OR\n" +
                                    "Click on Clear.");
                }
                else
                {
                    operation.Divide(DisplayValue);

                    string operationtx = txbx_Operation.Text;
                    operationtx = operationtx + "/";
                    txbx_Operation.Text = operationtx;

                    //setting prompt text box to 0 - reinitialize
                    txbx_Prompt.Text = "0";
                    flag = false;
                }


            }
            catch (Exception error)
            {
                MessageBox.Show("The value could not be converted to a Decimal value!\n"
                                + error.Message,
                                "Error!!!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
