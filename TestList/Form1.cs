using System.Xml;

namespace TestList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (peopleList.Text.Length != 0)
            {
                memberList.Add(peopleList.Text);
            }
            else MessageBox.Show("Выберите элемент из списка или введите новый");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            while (memberList.CheckedIndices.Count > 0) memberList.Items.RemoveAt(memberList.CheckedIndices[0]);
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            if (memberList.Sorted) { memberList.DESCSorted = true; this.buttonSort.Text = "Sort ↑"; }
            else { memberList.Sorted = true; this.buttonSort.Text = "Sort ↓"; }
            //extendedCheckedListBox1.DESCSorted = true; this.buttonSort.Text = "Sort ↑ NEW";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FileStream fStream = new FileStream("..\\..\\..\\XMLData.xml", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(fStream);
            for (int i = 0; i < xmlDoc.DocumentElement.ChildNodes.Count; i++)
            {
                peopleList.Items.Add(xmlDoc.DocumentElement.ChildNodes[i].InnerText);
            }
            fStream.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            memberList.Sorted = false;
        }
    }
}
