using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIOS21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2;
            num1 = int.Parse(text1.Text);
            num2 = int.Parse(text2.Text);
            if (num1 <= num2)
            {
                text3.Text = num2.ToString();
            }
            else
            {
                text3.Text = num1.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1a, num2a, num3a;
            num1a = int.Parse(textBox1.Text);
            num2a = int.Parse(textBox2.Text);
            num3a = int.Parse(textBox3.Text);

            if (num1a >= num2a && num1a >= num3a)
            {
                textBox4.Text = num1a.ToString();
            }
            else
            {
                if (num2a >= num1a && num2a >= num3a)
                {
                    textBox4.Text = num2a.ToString();
                }

                else
                {
                    textBox4.Text = num3a.ToString();
                }
            }

        }
    }


}


