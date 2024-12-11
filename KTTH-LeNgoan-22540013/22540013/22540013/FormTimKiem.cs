using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22540013
{
    public partial class FormTimKiem : Form
    {
        private List<Book> books;
        public FormTimKiem(List<Book> books)
        {
            InitializeComponent();
            this.books = books;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.textBox1.Text))
            {
                MessageBox.Show("Can chua nhap ten sach");
                return;
            }

            string tenSachCanTim=this.textBox1.Text;
            var ketQuaTimKiem = books.Where(book => book.TenSach.Contains(tenSachCanTim, StringComparison.OrdinalIgnoreCase)).ToList();

            if (ketQuaTimKiem.Any())
            {
                //CustomizeDataGridView();
                this.dataGridView1.DataSource = ketQuaTimKiem;
            }
            else
            {
                MessageBox.Show("Không tìm thấy sách.");
                this.dataGridView1.DataSource = null; 
            }

        }


        private void CustomizeDataGridView()
        {
            this.dataGridView1.Columns["STT"].HeaderText = "Số Thứ Tự";
            this.dataGridView1.Columns["TenSach"].HeaderText = "Tên Sách";
            this.dataGridView1.Columns["TacGia"].HeaderText = "Tác Giả";
            this.dataGridView1.Columns["TheLoai"].HeaderText = "Thể Loại";
            this.dataGridView1.Columns["SoLuongTon"].HeaderText = "Số Lượng Tồn";

            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
