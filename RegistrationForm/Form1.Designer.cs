﻿namespace RegistrationForm
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            checkBox1 = new CheckBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 11);
            label1.Name = "label1";
            label1.Size = new Size(145, 15);
            label1.TabIndex = 0;
            label1.Text = "Введите тип регистрации";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(33, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(335, 136);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Введите регистрационные данные";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(78, 64);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(183, 23);
            textBox2.TabIndex = 3;
            textBox2.Validating += textBox2_Validating;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(78, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(183, 23);
            textBox1.TabIndex = 2;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 67);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 1;
            label3.Text = "PIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 29);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 0;
            label2.Text = "Name";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(185, 183);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(183, 19);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Расширенные возможности";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(51, 232);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 3;
            button1.Text = "Регистрация";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 267);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Регистрация";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private CheckBox checkBox1;
        private Button button1;
    }
}
