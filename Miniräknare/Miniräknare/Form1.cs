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
        private string minOperator = ""; // operatorn som används (+,-,*,/)
        private double förraVärdet = 0; // det tidigare värdet som lagras i beräkningen
        private bool nyInmatning;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void num1_Click(object sender, EventArgs e)
        {
            siffror("1"); // lägger till siffran "1" till textDisplay
        }

        private void num2_Click(object sender, EventArgs e)
        {
            siffror("2"); // lägger till siffran "2" till textDisplay
        }

        private void num3_Click(object sender, EventArgs e)
        {
            siffror("3"); // och så vidare
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
            LikaMed(); // utför beräkningen med den aktuella operatorn
            minOperator = "+"; // sparar den nya operatorn
            nyInmatning = true; //startar en ny inmatning
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            LikaMed(); // utför beräkningen med den aktuella operatorn
            minOperator = ""; // tömmer operatorn
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            minOperator = ""; // Nollställer operatorn
            förraVärdet = 0; // återställer förraVärdet till 0
            textDisplay.Text = "0"; // återställer textDisplay
            nyInmatning = false;
        }
        private void LikaMed()
        {
            double nyttVärde; // det aktuella värdet som från display

            if (!double.TryParse(textDisplay.Text.Replace("i", ""), out nyttVärde)) // försöker konvertera textDisplay till double
            {
                MessageBox.Show("Error: Invalid input"); // felmeddelande vid ogiltig inmatning
                return;
            }

            switch (minOperator) // beräknar baserat på vilken operator som blev vald
            {
                case "+":
                    nyttVärde = förraVärdet + nyttVärde; // add
                    break;
                case "-":
                    nyttVärde = förraVärdet - nyttVärde; // sub
                    break;
                case "/":
                    if (nyttVärde == 0) // kontroll för division med 0
                    {
                        MessageBox.Show("Error: /0");
                        return;
                    }
                    nyttVärde = förraVärdet / nyttVärde; // div
                    break;
                case "*":
                    nyttVärde = förraVärdet * nyttVärde; // multi
                    break;

            }
            förraVärdet = nyttVärde; // sparar värdet
            textDisplay.Text = nyttVärde.ToString(); // visar resultatet i textDisplay
            nyInmatning = true; //nästa inmatning ska börja på nytt
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
            if (!textDisplay.Text.Contains(",")) // komma läggs till om det inte redan finns
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

                if (currentValue < 0) // om värdet är negativt
                {
                    result = Math.Sqrt(-currentValue);
                    isNegative = true;
                }
                else
                {
                    result = Math.Sqrt(currentValue);
                }

                textDisplay.Text = isNegative ? result.ToString() + "i" : result.ToString(); // uppdaterar textDisplay med resultatet. Any number squared will produce a positive number, so there is no true square root of a negative number. Square roots of negative numbers can only be determined using the imaginary number called an iota, or i.
                nyInmatning = true;
            }
        }
        
        private void siffror(string siffra) // metod för att hantera siffror
        {
            if (textDisplay.Text == "0" || nyInmatning) // kontrollerar om textDisplay är "0" eller om nyInmatning är true
            {
                textDisplay.Text = siffra; // ersätter textDisplay med den nya siffran
                nyInmatning = false;
            }
            else
            {
                textDisplay.Text += siffra; // lägger till siffran till befintlig text
            }
        }
    }
}
