using HCI_Lab3;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCI_Lab3
{
    public partial class Form2 : Form
    {

        public Form1 _form_1;
        public Form2(Form1 form_1)
        {
            InitializeComponent();
           _form_1 = form_1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
        public int Option;
        private void button1_Click(object sender, EventArgs e)
        {
            _form_1.button5.Enabled = true;
            _form_1.which_option = Option;
            _form_1.textBox1.Text = textBox1.Text; 

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Option = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Option = 2;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Option = 3;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Option = 4;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _form_1.button5.Enabled = false;
            this.Close();
        }
    }
}
