﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            string s="Tọa độ:"+e.X.ToString()+":"+e.Y.ToString();
            label1.Text = s;
            if (e.Button == MouseButtons.Left)
            {
                Graphics g = this.CreateGraphics();
                Pen pen = new Pen(Color.Red, 2f);

                g.DrawLine(pen, pA, e.Location);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            pA = e.Location;
        }
    }
}
