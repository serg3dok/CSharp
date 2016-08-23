using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCalc
{
    public partial class Form1 : Form
    {
        Double value = 0;
        Double storedValue = 0;
        String operation = "";
        String storedOperation = "";
        Boolean operation_pressed = false;


        public Form1()
        {
            InitializeComponent();
        }


        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (operation_pressed))
                result.Clear();
            operation_pressed = false;
            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
        }

        private void backClick(object sender, EventArgs e)
        {
            if (result.Text.Length < 2)
            {

                result.Text = result.Text.Remove(result.Text.LastIndexOf(result.Text.Length - 2, result.Text.Length));

            }

            //equation.Text = "";
            //result.Text = "0";
            //value = 0;
            //storedValue = 0;

        }

        private void operator_click(object sender, EventArgs e)
        {
            
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(result.Text);
            if (storedValue != 0)
            {
                switch (storedOperation)
                {
                    case "+":
                        equation.Text = storedValue + value + " " + operation;
                        storedValue = storedValue + value;
                        break;
                    case "-":
                        equation.Text = storedValue - value + " " + operation;
                        storedValue = storedValue - value;
                        break;
                    case "*":
                        equation.Text = storedValue * value + " " + operation;
                        storedValue = storedValue * value;
                        break;
                    case "/":
                        equation.Text = storedValue / value + " " + operation;
                        storedValue = storedValue / value;
                        break;
                    default:
                        break;
                } // end of switch
                result.Text = "";
                
                storedOperation = operation;

            }
            else
            {
                operation_pressed = true;
                equation.Text = value + " " + operation;
                storedValue = value;
                storedOperation = operation;
                result.Text = "";
            }
            
            
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            operation_pressed = false;
            equation.Text = "";
            Double lastValue = Double.Parse(result.Text);
            switch (operation)
            {
                case "+":
                    result.Text = (storedValue + lastValue).ToString();
                    storedValue = storedValue + lastValue;
                    break;
                case "-":
                    result.Text = (storedValue - lastValue).ToString();
                    storedValue = storedValue - lastValue;
                    break;
                case "*":
                    result.Text = (storedValue * lastValue).ToString();
                    storedValue = storedValue * lastValue;
                    break;
                case "/":
                    result.Text = (storedValue / lastValue).ToString();
                    storedValue = storedValue / lastValue;
                    break;
            }  // end switch;

        }

        private void button16_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            result.Text = "0";
            value = 0;
            storedValue = 0;
        }
    }
}
