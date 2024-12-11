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
        QuanLyBatDongSan admin;
        public Form1()
        {
            InitializeComponent();
            this.admin = new QuanLyBatDongSan();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string diaDiem = textBox1.Text;
            int giaBan=int.Parse(textBox2.Text);
            double dienTich=double.Parse(textBox3.Text);
           
            if(textBox4.Text.Length==0&&textBox5.Text.Length==0)
            {
                KhuDat khuDat = new KhuDat(diaDiem, giaBan, dienTich);
                admin.themSanPham(khuDat);
            }else if(textBox4.Text.Length==0&&textBox5.Text.Length!=0)
            {
                int soTang = int.Parse(textBox5.Text);
                ChungCu chungCu = new ChungCu(diaDiem, giaBan, dienTich, soTang);
                admin.themSanPham(chungCu);
            }else if(textBox4.Text.Length != 0 && textBox5.Text.Length != 0)
            {
                int namXaydung = int.Parse(textBox4.Text);
                int soTang = int.Parse(textBox5.Text);
                NhaPho nhaPho = new NhaPho(diaDiem,giaBan, dienTich, namXaydung, soTang);
                admin.themSanPham(nhaPho);
            }
            xuatDuLieuRaDatagrid(this.admin.danhSachSanPham);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KhuDat khuDat = new KhuDat("TPHCM", 500000000, 80);
            NhaPho nhaPho = new NhaPho("Ha Noi", 450000000, 100, 1972, 5);
            ChungCu chungCu = new ChungCu("Da Nang", 320000000, 54, 3);
            this.admin.themSanPham(khuDat);
            this.admin.themSanPham(nhaPho);
            this.admin.themSanPham(chungCu);
            xuatDuLieuRaDatagrid(this.admin.danhSachSanPham);
        }
        private void xuatDuLieuRaDatagrid(List<SanPham> danhSachSanPham)
        {
            dataGridView1.Rows.Clear();
            foreach (SanPham item in danhSachSanPham)
            {
                string[] rows = new string[5];
                if (item.GetType() == typeof(KhuDat))
                {
                    rows[0] = item.DiaDiem;
                    rows[1] = item.GiaBan.ToString();
                    rows[2] = item.DienTich.ToString();
                }
                else if (item.GetType() == typeof(NhaPho))
                {
                    rows[0] = item.DiaDiem;
                    rows[1] = item.GiaBan.ToString();
                    rows[2] = item.DienTich.ToString();
                    rows[3] = item.getSoTang().ToString();
                    rows[4] = item.getNamXayDung().ToString();
                }
                else
                {
                    rows[0] = item.DiaDiem;
                    rows[1] = item.GiaBan.ToString();
                    rows[2] = item.DienTich.ToString();
                    rows[3] = item.getSoTang().ToString();

                }

                dataGridView1.Rows.Add(rows);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Visible = true;
            int tongGiaBan=0;
            foreach(var item in this.admin.danhSachSanPham)
            {
                tongGiaBan += item.GiaBan;
            }
            label9.Text=tongGiaBan.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = this.admin.danhSachSanPham.Count - 1; i >= 0; i--) {
                if (this.admin.danhSachSanPham[i].DienTich>100&& this.admin.danhSachSanPham[i].GetType()==typeof(KhuDat)
                    ||(this.admin.danhSachSanPham[i].DienTich > 60 && this.admin.danhSachSanPham[i].GetType() == typeof(NhaPho) && this.admin.danhSachSanPham[i].getNamXayDung()>=2019 ))
                        this.admin.danhSachSanPham.RemoveAt(i);
                   
            }
            xuatDuLieuRaDatagrid(this.admin.danhSachSanPham);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<SanPham> danhSachSanPhamDuocTimKiem = new List<SanPham>();
            string diaChi = (textBox1.Text).ToLower();
            int giaTimKiem = int.Parse(textBox2.Text);
            double dienTichTimKiem = double.Parse(textBox3.Text);
            foreach(var item in this.admin.danhSachSanPham)
            {
                if (item.DiaDiem.ToLower().Contains(diaChi) && item.GiaBan <= giaTimKiem && dienTichTimKiem <= item.DienTich)
                {
                    Console.WriteLine("test dong 122");
                    danhSachSanPhamDuocTimKiem.Add(item);
                }
            }
            xuatDuLieuRaDatagrid(danhSachSanPhamDuocTimKiem);
        }
    }
}
