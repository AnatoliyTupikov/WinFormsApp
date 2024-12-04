using System.Diagnostics;
using System;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            richTextBox1.Text += "Mouse hover!\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "Click!\n";
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            richTextBox1.Text += "Click!\n";
            Debug.WriteLine("Click!");
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            Debug.WriteLine("Move!");
            
        }
    }
}
