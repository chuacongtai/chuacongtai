using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testmt
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnText_Click(object sender, EventArgs e)
        {
            btnText.Text = "Click me!";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            string dataToCopy = richTextBox1.Text;
            if (!string.IsNullOrEmpty(dataToCopy))
            {
                Clipboard.SetText(dataToCopy);

                MessageBox.Show("Copied to Clipboard!");
            }
            else
            {
                MessageBox.Show("Please enter data before copying.");
            }
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = @"private void btnText_Click(object sender, EventArgs e)
    {
        btnText.Text = ""Click me!"";
    }";
            richTextBox1.Focus();
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton4_Click(object sender, EventArgs e)
        {

        }
    }
}

