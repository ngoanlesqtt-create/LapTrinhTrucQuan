using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.IndexOf(textBox1.Text) >= 0)
                listBox1.SelectedItem = textBox1.Text;
            else if(textBox1.Text.Length> 0)
                listBox1.Items.Add(textBox1.Text);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex>=0)
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
    }
}
