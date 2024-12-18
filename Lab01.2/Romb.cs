﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01._2
{
    public partial class Romb : Form
    {

        public Romb()
        {
            InitializeComponent();

        }

        private void Romb_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddPolygon(new Point[] { new Point(this.Width / 2, 0), new Point(this.Width, this.Height / 2), new Point(this.Width / 2, this.Height), new Point(0, this.Height / 2) });
            Region myRegion = new Region(myPath);
            this.Region = myRegion;
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
