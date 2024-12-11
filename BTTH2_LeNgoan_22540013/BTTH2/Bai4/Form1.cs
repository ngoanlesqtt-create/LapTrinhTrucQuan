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
            thayDoiLabels();
            PhanSo phanSo1= new PhanSo();
            PhanSo phanSo2=new PhanSo();

            phanSo1.TuSo = int.Parse(textBox1.Text);
            phanSo1.MauSo=int.Parse(textBox2.Text);
            phanSo2.TuSo=int.Parse(textBox3.Text);
            phanSo2.MauSo=int.Parse(textBox4.Text);
            PhanSo ketQua=phanSo1+phanSo2;
            textBox5.Text = ketQua.TuSo.ToString();
            textBox6.Text = ketQua.MauSo.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            thayDoiLabels();
            PhanSo phanSo1 = new PhanSo();
            PhanSo phanSo2 = new PhanSo();

            phanSo1.TuSo = int.Parse(textBox1.Text);
            phanSo1.MauSo = int.Parse(textBox2.Text);
            phanSo2.TuSo = int.Parse(textBox3.Text);
            phanSo2.MauSo = int.Parse(textBox4.Text);
            PhanSo ketQua = phanSo1 - phanSo2;
            textBox5.Text = ketQua.TuSo.ToString();
            textBox6.Text = ketQua.MauSo.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            thayDoiLabels();
            PhanSo phanSo1 = new PhanSo();
            PhanSo phanSo2 = new PhanSo();

            phanSo1.TuSo = int.Parse(textBox1.Text);
            phanSo1.MauSo = int.Parse(textBox2.Text);
            phanSo2.TuSo = int.Parse(textBox3.Text);
            phanSo2.MauSo = int.Parse(textBox4.Text);
            PhanSo ketQua = phanSo1 * phanSo2;
            textBox5.Text = ketQua.TuSo.ToString();
            textBox6.Text = ketQua.MauSo.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            thayDoiLabels();
            PhanSo phanSo1 = new PhanSo();
            PhanSo phanSo2 = new PhanSo();

            phanSo1.TuSo = int.Parse(textBox1.Text);
            phanSo1.MauSo = int.Parse(textBox2.Text);
            phanSo2.TuSo = int.Parse(textBox3.Text);
            phanSo2.MauSo = int.Parse(textBox4.Text);
            PhanSo ketQua = phanSo1 / phanSo2;
            textBox5.Text = ketQua.TuSo.ToString();
            textBox6.Text = ketQua.MauSo.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            thayDoiLabels();
            PhanSo phanSo1 = new PhanSo();
            PhanSo phanSo2 = new PhanSo();

            phanSo1.TuSo = int.Parse(textBox1.Text);
            phanSo1.MauSo = int.Parse(textBox2.Text);
            phanSo2.TuSo = int.Parse(textBox3.Text);
            phanSo2.MauSo = int.Parse(textBox4.Text);
            bool ketQua = phanSo1 > phanSo2;
            if (!ketQua)
            {
                textBox5.Text = phanSo1.TuSo.ToString();
                textBox6.Text = phanSo1.MauSo.ToString();
            }
            else
            {
                textBox5.Text = phanSo2.TuSo.ToString();
                textBox6.Text = phanSo2.MauSo.ToString();
            }
        }
        private void thayDoiLabels()
        {
            label8.Text = "Tử số:";
            label9.Text = "Mẫu số:";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label8.Text = "Phân số 1:";
            label9.Text = "Phân số 2:";
            PhanSo phanSo1 = new PhanSo();
            PhanSo phanSo2 = new PhanSo();

            phanSo1.TuSo = int.Parse(textBox1.Text);
            phanSo1.MauSo = int.Parse(textBox2.Text);
            phanSo2.TuSo = int.Parse(textBox3.Text);
            phanSo2.MauSo = int.Parse(textBox4.Text);
            if (phanSo1 > phanSo2)
            {
                textBox6.Text=phanSo1.TuSo.ToString()+"/"+phanSo1.MauSo.ToString();
                textBox5.Text = phanSo2.TuSo.ToString() + "/" + phanSo2.MauSo.ToString();
            }
            else
            {
                textBox5.Text = phanSo1.TuSo.ToString() + "/" + phanSo1.MauSo.ToString();
                textBox6.Text = phanSo2.TuSo.ToString() + "/" + phanSo2.MauSo.ToString();
            }
        }
    }
}
