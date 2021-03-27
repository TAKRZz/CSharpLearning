using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HomeWork1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string arr1 = textBox1.Text;
            int num1 = 0;
            for(int i = 0; i < arr1.Length; i++)
            {
                num1 *= 10;
                num1 += ((int)arr1[i] - (int)'0');
            }
            string arr2 = textBox2.Text;
            int num2 = 0;
            for (int i = 0; i < arr2.Length; i++)
            {
                num2 *= 10;
                num2 += ((int)arr2[i] - (int)'0');
            }
            if (radioButton1.Checked)
            {
                long num3 = num1 - num2;
                label3.Text = num3.ToString();
            }
            else if (radioButton2.Checked)
            {
                long num3 = num1 * num2;
                label3.Text = num3.ToString();
            }
            else if (radioButton3.Checked)
            {
                if(num2 == 0)
                {
                    label3.Text = "输入有误！";
                    return;
                }
                double num3 = (double)num1 / (double)num2;
                label3.Text = num3.ToString();
            }
            else if (radioButton4.Checked)
            {
                long num3 = num1 + num2;
                label3.Text = num3.ToString();
            }

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
