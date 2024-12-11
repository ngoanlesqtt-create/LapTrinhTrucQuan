using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    internal class QuanLyBatDongSan
    {
        public List<SanPham> danhSachSanPham { get; set; }
        public QuanLyBatDongSan()
        {
            this.danhSachSanPham = new List<SanPham>();
        }
        public List<SanPham> themSanPham(SanPham sanPham)
        {
            this.danhSachSanPham.Add(sanPham);
            return this.danhSachSanPham ;
        }

    
     
    }
}
