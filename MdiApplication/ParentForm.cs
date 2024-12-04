using System.Runtime.CompilerServices;

namespace MdiApplication
{
    public partial class ParentForm : Form
    {
        private uint countChild = 0;

        public ParentForm()
        {
            InitializeComponent();
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
            newChild.Text =  this.countChild == 0 ? "Child" : "Child" + countChild;
            newChild.MdiParent = this;
            newChild.Show();
            countChild++;
        }
    }
}
