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
    public partial class FormThemMoi : Form
    {

        private List<Book> _books;

        public FormThemMoi(List<Book> books)
        {
            this._books = books;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(this.textBox2.Text) || string.IsNullOrWhiteSpace(textBox4.Text) ||
            string.IsNullOrWhiteSpace(textBox3.Text) || !int.TryParse(textBox5.Text, out int quantity))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin và số lượng hợp lệ.");
                return;
            }

            string tenSach = this.textBox2.Text;
            string tacGia = this.textBox3.Text;
            string theLoai = this.textBox4.Text;
        

            Book newBook = new Book
            {
                STT = _books.Count + 1,
                TenSach = tenSach,
                TacGia = tacGia,
                TheLoai = theLoai,
                SoLuongTon = quantity
            };

            _books.Add(newBook);
            MessageBox.Show("Thêm sách thành công!");
            this.Close();
        }
    }
}
