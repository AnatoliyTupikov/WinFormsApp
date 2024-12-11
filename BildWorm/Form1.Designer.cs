namespace BiblWorm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            numericUpDown4 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            numericReleaseYear = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            tabPage2 = new TabPage();
            richTextBox1 = new RichTextBox();
            button3 = new Button();
            checkBox3 = new CheckBox();
            listBox1 = new ListBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericReleaseYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Left;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(276, 411);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(listBox1);
            tabPage1.Controls.Add(checkBox2);
            tabPage1.Controls.Add(checkBox1);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(numericUpDown4);
            tabPage1.Controls.Add(numericUpDown3);
            tabPage1.Controls.Add(numericReleaseYear);
            tabPage1.Controls.Add(numericUpDown1);
            tabPage1.Controls.Add(textBox3);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(268, 383);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Книги";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(123, 292);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(130, 19);
            checkBox2.TabIndex = 16;
            checkBox2.Text = "Возвращает в срок";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(16, 292);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(75, 19);
            checkBox1.TabIndex = 15;
            checkBox1.Text = "Наличие";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(16, 326);
            button1.Name = "button1";
            button1.Size = new Size(237, 37);
            button1.TabIndex = 14;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 86);
            label7.Name = "label7";
            label7.Size = new Size(81, 15);
            label7.TabIndex = 13;
            label7.Text = "Издательство";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 44);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 12;
            label6.Text = "Название";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 15);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 11;
            label5.Text = "Автор";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 255);
            label4.Name = "label4";
            label4.Size = new Size(109, 15);
            label4.TabIndex = 10;
            label4.Text = "Срок пользования";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 213);
            label3.Name = "label3";
            label3.Size = new Size(122, 15);
            label3.TabIndex = 9;
            label3.Text = "Инвентарный номер";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 171);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 8;
            label2.Text = "Год издания";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 129);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 7;
            label1.Text = "Страниц";
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(144, 253);
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(109, 23);
            numericUpDown4.TabIndex = 6;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(144, 211);
            numericUpDown3.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(109, 23);
            numericUpDown3.TabIndex = 5;
            numericUpDown3.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericReleaseYear
            // 
            numericReleaseYear.Location = new Point(103, 169);
            numericReleaseYear.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numericReleaseYear.Minimum = new decimal(new int[] { 500, 0, 0, 0 });
            numericReleaseYear.Name = "numericReleaseYear";
            numericReleaseYear.Size = new Size(150, 23);
            numericReleaseYear.TabIndex = 4;
            numericReleaseYear.Value = new decimal(new int[] { 500, 0, 0, 0 });
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(103, 127);
            numericUpDown1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 23);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // textBox3
            // 
            textBox3.Location = new Point(103, 82);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(103, 47);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(103, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 23);
            textBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(268, 383);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Журналы";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(278, 24);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(364, 329);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // button3
            // 
            button3.Location = new Point(282, 364);
            button3.Name = "button3";
            button3.Size = new Size(127, 23);
            button3.TabIndex = 3;
            button3.Text = "Посмотреть";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(442, 351);
            checkBox3.MaximumSize = new Size(200, 0);
            checkBox3.MinimumSize = new Size(0, 50);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(200, 50);
            checkBox3.TabIndex = 4;
            checkBox3.Text = "Сортировать по инвентраному номер";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(103, 31);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 4);
            listBox1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 411);
            Controls.Add(checkBox3);
            Controls.Add(button3);
            Controls.Add(richTextBox1);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Библиотека";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericReleaseYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private NumericUpDown numericUpDown4;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericReleaseYear;
        private NumericUpDown numericUpDown1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private TabPage tabPage2;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button button1;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private RichTextBox richTextBox1;
        private Button button3;
        private CheckBox checkBox3;
        private ListBox listBox1;
    }
}
