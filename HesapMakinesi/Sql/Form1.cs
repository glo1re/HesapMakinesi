using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += button5.Text;
        }
        

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += button9.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += button11.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += button10.Text;
        }
        float First, Second;

        private void button17_Click(object sender, EventArgs e)
        {
            Second = float.Parse(textBox1.Text);
            if (a == 1)
            {
                textBox1.Text = (First + Second).ToString();
            }
            if (a == 2)
            {
                textBox1.Text = (First - Second).ToString();
            }
            if (a == 3)
            {
                textBox1.Text = (First * Second).ToString();
            }
            if (a == 4)
            {
                textBox1.Text = (First / Second).ToString();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            a = 2;
            First = float.Parse(textBox1.Text);
            textBox1.Text += button13.Text;
            textBox1.Text = null;
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            a = 3;
            First = float.Parse(textBox1.Text);
            textBox1.Text += button13.Text;
            textBox1.Text = null;
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            a = 4;
            First = float.Parse(textBox1.Text);
            textBox1.Text += button13.Text;
            textBox1.Text = null;
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            a = 0;
            First = 0;
            Second = 0;
            textBox1.Text = null;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            a = 1;
            First = float.Parse(textBox1.Text);
            textBox1.Text += button13.Text;
            textBox1.Text = null;
            
            
        }
    }
}
