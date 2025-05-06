using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miniräknare
{
    public partial class Form1 : Form
    {
        private string minOperator = "";
        private double förraVärdet = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void num1_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "1";
            }
            else
            {
                textDisplay.Text += "1";
            }
        }

        private void num2_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "2";
            }
            else
            {
                textDisplay.Text += "2";
            }
        }

        private void num3_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "3";
            }
            else
            {
                textDisplay.Text += "3";
            }
        }

        private void num4_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "4";
            }
            else
            {
                textDisplay.Text += "4";
            }
        }

        private void num5_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "5";
            }
            else
            {
                textDisplay.Text += "5";
            }
        }

        private void num6_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "6";
            }
            else
            {
                textDisplay.Text += "6";
            }
        }

        private void num7_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "7";
            }
            else
            {
                textDisplay.Text += "7";
            }
        }

        private void num8_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "8";
            }
            else
            {
                textDisplay.Text += "8";
            }
        }

        private void num9_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "9";
            }
            else
            {
                textDisplay.Text += "9";
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            LikaMed();
            minOperator = "+";
            textDisplay.Text = "0";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            LikaMed();
            minOperator = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            minOperator = "";
            förraVärdet = 0;
            textDisplay.Text = "0";
        }
        private void LikaMed()
        {
            double nyttVärde;
            if (textDisplay.Text.Contains("√"))
            {
                textDisplay.Text = textDisplay.Text.Remove(0, 1);
            }
            if (!double.TryParse(textDisplay.Text, out nyttVärde))
            {
                return;
            }
            

            switch (minOperator)
            {
                case "+":
                    nyttVärde = förraVärdet + nyttVärde;
                    break;
                case "-":
                    nyttVärde = förraVärdet - nyttVärde;
                    break;
                case "/":
                    nyttVärde = förraVärdet / nyttVärde;
                    break;
                case "*":
                    nyttVärde = förraVärdet * nyttVärde;
                    break;
                case "√":
                    nyttVärde = Math.Sqrt(nyttVärde);
                    break;
            }
            förraVärdet = nyttVärde;
            textDisplay.Text = nyttVärde.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            LikaMed();
            minOperator = "/";
            textDisplay.Text = "0";
        }

        private void num0_Click(object sender, EventArgs e)
        {
            if(textDisplay.Text != "0")
            {
                textDisplay.Text += "0";
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            LikaMed();
            minOperator = "-";
            textDisplay.Text = "0";
        }

        private void btnComma_Click(object sender, EventArgs e)
        {
            if (!textDisplay.Text.Contains(","))
            {
                textDisplay.Text += ",";
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            LikaMed();
            minOperator = "*";
            textDisplay.Text = "0";
        }

        private void btnSqr_Click(object sender, EventArgs e)
        {
            textDisplay.Text = "√";
            minOperator = "√";
        }
    }
}
