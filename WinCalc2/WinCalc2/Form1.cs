using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCalc2
{
    public partial class Form1 : Form
    {
        private Decimal value = 0;
        private string operation = "";
        private bool operation_pressed = false; 
        Decimal storedValue = 0;
        private string storedOperation = "";



        public Form1()
        {
            InitializeComponent();
        }

        private void number_click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (operation_pressed))
                result.Clear();
            operation_pressed = false;
            Button b = (Button) sender;
            result.Text = result.Text + b.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            operation_pressed = false;
            result.Text = "0";
            mem.Text = "";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            
            operation_pressed = true;

            if (!storedOperation.Equals("") && (!result.Text.Equals("")))
            {

                calculation();

                //switch (storedOperation)
                //{
                //    case "/":
                //        if (value == 0)
                //        {
                //            MessageBox.Show("Sorry, you can't divide by 0", "Warning");
                //            break;
                //        }
                //        result.Text = (storedValue / value).ToString();
                //        storedValue = storedValue/value;
                //        break;
                //    case "*":
                //        result.Text = (storedValue * value).ToString();
                //        storedValue = storedValue*value;
                //        break;
                //    case "-":
                //        result.Text = (storedValue - value).ToString();
                //        storedValue = storedValue - value;
                //        break;
                //    case "+":
                //        result.Text = (storedValue + value).ToString();
                //        storedValue = storedValue + value;
                //        break;
                //    default:
                //        break;
                //} // end of switch


                mem.Text = result.Text + " " + operation;
                value = Decimal.Parse(result.Text);
                result.Text = "";
                storedOperation = operation;
            }
            else if (result.Text.Equals(""))
            {
                mem.Text = storedValue + " " + operation;
                storedOperation = operation;
            }
            else
            {
                value = Decimal.Parse((result.Text));
                mem.Text = value + " " + operation;
                result.Clear();
                //storedValue = value;
                storedOperation = operation;
            }
            


        }

        private void equals_click(object sender, EventArgs e)
        {
            operation_pressed = false;
            mem.Text = "";
            //switch (operation)
            //{
            //    case "/":
            //        if (Decimal.Parse((result.Text)) == 0)
            //        {
            //            MessageBox.Show("Sorry, you can't divide by 0", "Warning");
            //            break;
            //        }
            //        result.Text = (value / Decimal.Parse((result.Text))).ToString();
            //        break;
            //    case "*":
            //        result.Text = (value * Decimal.Parse((result.Text))).ToString();
            //        break;
            //    case "-":
            //        result.Text = (value - Decimal.Parse((result.Text))).ToString();
            //        break;
            //    case "+":
            //        result.Text = (value + Decimal.Parse((result.Text))).ToString();
            //        break;
            //    default:
            //        break;
            //} // end of switch
            

        }

        private void C_click(object sender, EventArgs e)
        {
            mem.Text = "";
            result.Text = "0";
            value = 0;
            storedValue = 0;
            storedOperation = "";
        }

        private void calculation()
        {
            Decimal res = 0;
            switch (storedOperation)
            {
                case "/":
                    if (value == 0)
                    {
                        MessageBox.Show("Sorry, you can't divide by 0", "Warning");
                        break;
                    }
                    res = storedValue / value;

                    break;
                case "*":
                    res = storedValue * value;
                    break;
                case "-":
                    res = storedValue - value;
                    break;
                case "+":
                    res = storedValue + value;
                    break;
                default:
                    break;
            } // end of switch
        }
    }
}
