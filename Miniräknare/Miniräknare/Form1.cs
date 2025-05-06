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
            siffror("1");
        }

        private void num2_Click(object sender, EventArgs e)
        {
            siffror("2");
        }

        private void num3_Click(object sender, EventArgs e)
        {
            siffror("3");
        }

        private void num4_Click(object sender, EventArgs e)
        {
            siffror("4");
        }

        private void num5_Click(object sender, EventArgs e)
        {
            siffror("5");
        }

        private void num6_Click(object sender, EventArgs e)
        {
            siffror("6");
        }

        private void num7_Click(object sender, EventArgs e)
        {
            siffror("7");
        }

        private void num8_Click(object sender, EventArgs e)
        {
            siffror("8");
        }

        private void num9_Click(object sender, EventArgs e)
        {
            siffror("9");
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            LikaMed();
            minOperator = "+";
            nyInmatning = true;
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
            nyInmatning = false;
        }
        private void LikaMed()
        {
            double nyttVärde;

            if (!double.TryParse(textDisplay.Text.Replace("i", ""), out nyttVärde))
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
                    if (nyttVärde == 0)
                    {
                        MessageBox.Show("Error: /0");
                        return;
                    }
                    nyttVärde = förraVärdet / nyttVärde;
                    break;
                case "*":
                    nyttVärde = förraVärdet * nyttVärde;
                    break;

            }
            förraVärdet = nyttVärde;
            textDisplay.Text = nyttVärde.ToString();
            nyInmatning = true;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            LikaMed();
            minOperator = "/";
            nyInmatning = true;
        }

        private void num0_Click(object sender, EventArgs e)
        {
            siffror("0");
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            LikaMed();
            minOperator = "-";
            nyInmatning = true;
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
            nyInmatning = true;
        }

        private void btnSqr_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textDisplay.Text, out double currentValue))
            {
                double result;
                bool isNegative = false;

                if (currentValue < 0)
                {
                    result = Math.Sqrt(-currentValue);
                    isNegative = true;
                }
                else
                {
                    result = Math.Sqrt(currentValue);
                }

                textDisplay.Text = isNegative ? result.ToString() + "i" : result.ToString();
                nyInmatning = true;
            }
        }
        private bool nyInmatning;
        private void siffror(string siffra)
        {
            if (textDisplay.Text == "0" || nyInmatning)
            {
                textDisplay.Text = siffra;
                nyInmatning = false;
            }
            else
            {
                textDisplay.Text += siffra;
            }
        }
    }
}
