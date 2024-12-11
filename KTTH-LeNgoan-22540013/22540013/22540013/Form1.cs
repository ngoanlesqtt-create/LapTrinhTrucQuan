namespace _22540013
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.books = new List<Book>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.books = new List<Book>
            {
                new Book { STT = 1, TenSach = "Lập trình hướng đối tượng", TacGia = "Trương Hải Bang", TheLoai = "Giáo trình", SoLuongTon = 5 },
                new Book { STT = 2, TenSach = "Lập trình trên window", TacGia = "Vũ Thanh Nguyên", TheLoai = "Giáo trình", SoLuongTon = 20 },
                new Book { STT = 3, TenSach = "Đại số tuyến tính", TacGia = "Cao Thanh Tinh", TheLoai = "Giáo trình", SoLuongTon = 0 },
                new Book { STT = 4, TenSach = "Phân tích thiết kế hệ thống thông tin", TacGia = "Cao Thị Nhạn", TheLoai = "Giáo trình", SoLuongTon = 0 },
                new Book { STT = 5, TenSach = "Hướng dân thực hành phất triển ứng dụng T", TacGia = "Trần Hồng Nghi", TheLoai = "Thực hành", SoLuongTon = 5 }
            };

            this.dataGridView1.DataSource = books;
            CustomizeDataGridView();

            comboBox1.Items.Add("Tất cả sách");
            comboBox1.Items.Add("Sách còn");
            comboBox1.Items.Add("Sách đã hết");

            comboBox1.SelectedIndex = 0;

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
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            FormGioiThieu formGioiThieu = new FormGioiThieu();
            formGioiThieu.Show();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            FormThemMoi formThemMoi = new FormThemMoi(this.books);
            formThemMoi.ShowDialog();
            UpdateDataGridView();
        }

        private void UpdateDataGridView()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = books;
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            FormTimKiem formTimKiem = new FormTimKiem(this.books);
            formTimKiem.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Sách còn":
                    var sachCon = this.books.FindAll(x => x.SoLuongTon > 0).ToList();
                    this.dataGridView1.DataSource = sachCon;
                    CustomizeDataGridView();
                    break;

                case "Sách đã hết":
                    var sachHet = this.books.FindAll(x => x.SoLuongTon == 0).ToList();
                    this.dataGridView1.DataSource = sachHet;
                    CustomizeDataGridView();
                    break;
                case "Tất cả sách":
                    this.dataGridView1.DataSource = this.books;
                    CustomizeDataGridView();
                    break;



            }
        }
    }
}
