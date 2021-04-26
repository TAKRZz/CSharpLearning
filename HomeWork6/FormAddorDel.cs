using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork6
{
    public partial class FormAddorDel : Form
    {
        public static string arr1, arr2, arr3, arr4; 
        public FormAddorDel()
        {
            InitializeComponent();
        }

        private void FormAddorDel_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            arr1 = this.textBox1.Text;
            arr2 = this.textBox2.Text;
            arr3 = this.textBox3.Text;
            arr4 = this.textBox4.Text;
            this.Close();
            
        }
    }
}
