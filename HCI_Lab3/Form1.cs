using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCI_Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result_1 = MessageBox.Show("Yes, No, Cancel", "YESNOCANCEL", MessageBoxButtons.YesNoCancel);

            if (result_1 == DialogResult.Yes)
            {
                textBox1.Text = "Yes";
            }
            else if (result_1 == DialogResult.No)
            {
                textBox1.Text = "No";
            }
            else if (result_1 == DialogResult.Cancel)
            {
                textBox1.Text = "Cancel";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result_2 = MessageBox.Show("Abort, Retry, Ignore", "AbortRetryIgnore", MessageBoxButtons.AbortRetryIgnore);

            if (result_2 == DialogResult.Abort)
            {
                textBox1.Text = "Abort";
            }
            else if (result_2 == DialogResult.Retry)
            {
                textBox1.Text = "Retry";
            }
            else if (result_2 == DialogResult.Ignore)
            {
                textBox1.Text = "Ignore";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog  saveDlg = new SaveFileDialog();
            saveDlg.Filter = "All Files|*.*|Text File (.txt)|*.txt|RTF Files (*.rtf)|*.rtf|Word File (.docx ,.doc)|*.doc";
            if (saveDlg.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter  file = new System.IO.StreamWriter(saveDlg.FileName);
                file.Write(textBox1.Text.ToString());
                file.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var send_form = new Form2(this);
            send_form.Show();

        }

        public int which_option;
        public void button5_Click(object sender, EventArgs e)
        {
            if(which_option == 1)
            {
                textBox1.Text = "Option 1";
            }
            else if(which_option == 2)
            {
                textBox1.Text = "Option 2";
            }
            else if (which_option == 3)
            {
                textBox1.Text = "Option 3";
            }
            else if (which_option == 4)
            {
                textBox1.Text = "Option 4";
            }
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
