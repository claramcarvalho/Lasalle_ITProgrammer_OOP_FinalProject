using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    internal class Calc
    {
        private decimal currentValue;
        private decimal operand1;
        private decimal operand2;
        private string op;

        public decimal CurrentValue
        {
            get { return currentValue; }
            set { currentValue = value; }
        }

        public string Op
        {
            get { return op; }
            set { op = value; }
        }

        public Calc()
        {
            currentValue = 0;
            operand1 = 0;
            operand2 = 0;
            op = null;
        }

        public void Add (decimal displayValue)
        {
            operand1 = displayValue;
            CurrentValue = displayValue;
            op = "+";
        }

        public void Subtract(decimal displayValue)
        {
            operand1 = displayValue;
            CurrentValue = displayValue;
            op = "-";
        }

        public void Multiply(decimal displayValue)
        {
            operand1 = displayValue;
            CurrentValue = displayValue;
            op = "*";
        }

        public void Divide(decimal displayValue)
        {
            operand1 = displayValue;
            CurrentValue = displayValue;
            op = "/";
        }

        public void Equals(decimal displayValue)
        {
            operand2 = displayValue;

            switch (op)
            {
                case "+":
                    CurrentValue = operand1 + operand2;
                    break;
                case "-":
                    CurrentValue = operand1 - operand2;
                    break;
                case "*":
                    CurrentValue = operand1 * operand2;
                    break;
                case "/":
                    CurrentValue = operand1 / operand2;
                    break;
                default:
                    break;
            }
        }

        public void Clear()
        {
            currentValue = 0;
            operand1 = 0;
            operand2 = 0;
            op = null;
        }
    }
}
