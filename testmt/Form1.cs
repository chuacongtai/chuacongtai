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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int clickCount = 0;
        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            clickCount++;
            if (clickCount % 2 == 1)
            {
                btnChangeColor.BackColor = Color.Gray;
                btnChangeColor.ForeColor = Color.White;
            }
            else
            {
                btnChangeColor.BackColor = SystemColors.Control;
                btnChangeColor.ForeColor = SystemColors.ControlText;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
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

        //Button khi click vào sẽ thay đổi màu chữ và màu nền ấn lần nữa để trở về ban đầu
        //Cách sử dụng:
        //-Tạo 
    }
}
