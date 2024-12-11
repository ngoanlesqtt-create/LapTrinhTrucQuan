using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form1 : Form
    {
        private int[,] matrix;
        public Form1()
        {
            InitializeComponent();
        }
        private void khoiTaoMangHaiChieu(ref int[,] matrix)
        {
            Random random = new Random();
            
            for (int i = 0;i< matrix.GetLength(0); i++)
                for(int j=0;j< matrix.GetLength(1); j++)
                    matrix[i,j] = random.Next(1, 10);
        }
        private void hienThiMangHaiChieu(int[,] matrix)
        {
           
            dataGridView1.ColumnCount = matrix.GetLength(1);
            string[] row;
            for (int i = 0; i < matrix.GetLength(1); i++)
                dataGridView1.Columns[i].Name = "Column " + (i + 1);
        
            for (int i=0;i<matrix.GetLength(0); i++)
            {
                row = new string[matrix.GetLength(1)];
                for(int j=0;j<matrix.GetLength(1); j++)
                    row[j] = matrix[i,j].ToString();
                dataGridView1.Rows.Add(row);
            }

        }
        private void xuatMaTran(int[,] matrix)
        {
            for(int i=0;i< matrix.GetLength(0); i++)
            {
                for(int j=0;j<matrix.GetLength(1); j++)
                    Console.Write(matrix[i,j]+" ");
                Console.WriteLine();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.matrix != null)
                dataGridView1.Rows.Clear();
            int hang = int.Parse(textBox1.Text);
            int cot= int.Parse(textBox2.Text);  
            
            this.matrix=new int[hang, cot];
            khoiTaoMangHaiChieu(ref matrix);
            hienThiMangHaiChieu(matrix);
            xuatMaTran( matrix);
        }
        private bool timPhanTu(int[,] matrix, int phanTuCanTim, ref int hang, ref int cot) {

            for(int i=0;i<matrix.GetLength(0);++i)
                for(int j=0;j<matrix.GetLength(1); ++j)
                    if (matrix[i, j] == phanTuCanTim)
                    {
                        hang = i+1;
                        cot = j+1;
                        return true;
                    }

 
            return false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (this.matrix == null) MessageBox.Show("Ban chua tao ma tran!!!Ahihi");
            else
            {
                if (textBox3.Text.Length == 0)
                    MessageBox.Show("Ban chua nhap so can tim:D");
                else
                {
                    int hang=0, cot=0;
                    int phanTuCanTim = int.Parse(textBox3.Text);
                    bool ketQuaTimKiem = timPhanTu(this.matrix, phanTuCanTim,ref hang, ref cot);
                    if (ketQuaTimKiem)
                        MessageBox.Show("Phan tu duoc tim thay o hang:" + hang + " cot:" + cot);
                    else MessageBox.Show("Khong tim thay phan tu can tim!!!");
                }
              

            }
        }
        private bool kiemTraSoNguyenTo(int soCanKiemTra)
        {
            for (int i = 2; i <= Math.Sqrt(soCanKiemTra); i++)
                if (soCanKiemTra % i == 0)
                    return true;

            return false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (this.matrix == null) MessageBox.Show("Ban chua tao ma tran");
            else
            {
                dataGridView1.Rows.Clear();
                int soNguyenToTrenDongLonNhat = 0;
                int dongCoNhieuSoNguyenToNhat = -1;
                string[] rows;
                for(int i = 0; i < this.matrix.GetLength(0); ++i)
                {
                    rows = new string[this.matrix.GetLength(1)];
                    int soNguyenToTrenDong = 0;
                    for(int j=0;j<this.matrix.GetLength(1);++j)
                        if (!kiemTraSoNguyenTo(matrix[i,j]))
                        {
                            rows[j]=matrix[i,j].ToString();
                            soNguyenToTrenDong++;
                        }
                    if (soNguyenToTrenDong > soNguyenToTrenDongLonNhat)
                    {
                        soNguyenToTrenDongLonNhat = soNguyenToTrenDong;
                        dongCoNhieuSoNguyenToNhat = i;
                    }
                    dataGridView1.Rows.Add(rows);
                    if (dongCoNhieuSoNguyenToNhat == -1)
                        MessageBox.Show("Khong co so nguyen to trong ma tran");
                    else
                    {
                        label4.Visible = true;
                        label4.Text = "Dong co nhieu so nguyen to nhat la:" + dongCoNhieuSoNguyenToNhat;
                    }
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
