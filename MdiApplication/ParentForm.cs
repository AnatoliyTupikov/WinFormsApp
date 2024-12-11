using System.Runtime.CompilerServices;

namespace MdiApplication
{
    public partial class ParentForm : Form
    {
        private uint countChild = 0;

        public ParentForm()
        {
            InitializeComponent();
            spData.Text = Convert.ToString(System.DateTime.Today.ToLongDateString());
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WindowCascadeMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void WindowTileMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void NewMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm newChild = new ChildForm();
            newChild.Text = this.countChild == 0 ? "Child" : "Child" + countChild;
            newChild.MdiParent = this;
            newChild.Show();
            countChild++;
        }



        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Tag.ToString())
            {
                case "NewDoc":
                    ChildForm newChild = new ChildForm();
                    newChild.MdiParent = this;
                    newChild.Show();
                    newChild.Text = newChild.Text + " " + ++countChild;
                    break;
                case "Cascade":
                    this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
                    break;
                case "Title":
                    this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
                    break;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            spWin.Text = "Windows is cascade";
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            spWin.Text = "Windows is horizontal";
        }
    }
}
