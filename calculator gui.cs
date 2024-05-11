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

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c;
            if (radioButton1.Checked)
            {
                c = a + b;
                label10.Text = c.ToString();
                label13.Text = "Sum";
            }
            if (radioButton2.Checked)
            {
                c = a - b;
                label10.Text = c.ToString();
                label13.Text = "Difference";
            }
            if (radioButton3.Checked)
            {
                c = a * b;
                label10.Text = c.ToString();
                label13.Text = "Product";
            }
            if (radioButton4.Checked)
            {
                c = a / b;
                label10.Text = c.ToString();
                label13.Text = "Quotient";
            }
            if (radioButton5.Checked)
            {
                c = a % b;
                label10.Text = c.ToString();
                label13.Text = "Modulo";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            label10.Text = " ";
            label13.Text = " ";
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
