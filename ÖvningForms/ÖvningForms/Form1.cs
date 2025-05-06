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

namespace ÖvningForms
{
    public partial class Form1 : Form
    {
        DateTime start;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnClickThis.Select();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (btnClickThis.Text == "Start")
            {
                start = DateTime.Now;
                timer1.Start();
                btnClickThis.Text = "Stop";
                
            }
            else
            {
                timer1.Stop();
                btnClickThis.Text = "Start";
            }
        }

        private void lblHelloWorld_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan tid = DateTime.Now - start;
                lblHelloWorld.Text = tid.Minutes.ToString().PadLeft(2, '0') + ":" + tid.Seconds.ToString().PadLeft(2, '0') + ":" + tid.Milliseconds.ToString().PadLeft(3, '0');

        }

        private void pause_Click(object sender, EventArgs e)
        {
            
        }
    }
}
