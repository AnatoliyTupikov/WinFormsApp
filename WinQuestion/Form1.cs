using System.Diagnostics;

namespace WinQuestion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnyes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Мы и не сомневались, что Вы так думаете!");
        }

        private void btnno_MouseMove(object sender, MouseEventArgs e)
        {
            //btnno.Top -= e.Y;
            //btnno.Left += e.X;
            Debug.WriteLine($"{e.X},{e.Y}");
        //    if (btnno.Top < -10 || btnno.Top > 100)
        //        btnno.Top = 60;
        //    if (btnno.Left < -80 || btnno.Left > 250)
        //        btnno.Left = 120;
        }
    }
}
