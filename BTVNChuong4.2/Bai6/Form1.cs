using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection item=listView1.SelectedItems;
            if (item.Count > 0)
            {
                string string1 = item[0].Text;
                string string2 = item[0].SubItems[1].Text;
                MessageBox.Show(string1+"-"+string2);
            }


        }
    }
}
