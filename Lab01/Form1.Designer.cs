namespace Lab01
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
            close_btn = new Button();
            SuspendLayout();
            // 
            // close_btn
            // 
            close_btn.Anchor = AnchorStyles.None;
            close_btn.BackColor = Color.IndianRed;
            close_btn.ForeColor = SystemColors.ControlText;
            close_btn.Location = new Point(352, 203);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(75, 23);
            close_btn.TabIndex = 0;
            close_btn.Text = "Close";
            close_btn.UseVisualStyleBackColor = false;
            close_btn.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(800, 450);
            Controls.Add(close_btn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button close_btn;
    }
}
