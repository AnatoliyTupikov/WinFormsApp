namespace Lab01._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            var romb = new Romb();
            romb.ShowDialog();
            this.Close();
        }

    }
}
