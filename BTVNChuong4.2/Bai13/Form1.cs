using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AddDateTimePicker();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now= DateTime.Now;
            label1.Text = now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            label2.Text=progressBar1.Value.ToString()+"%";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(listBox1, "Danh sách họ tên");
        }
    }
}
