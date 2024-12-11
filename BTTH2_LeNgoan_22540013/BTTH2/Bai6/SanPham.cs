using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    internal class SanPham
    {
        public string DiaDiem { get; set; }
        public int GiaBan { get; set; }
        public double DienTich { get; set; }
        public string Loai { get; set; }

        public SanPham( string diaDiem, int giaBan, double dienTich )
        {
            DiaDiem = diaDiem;
            GiaBan = giaBan;
            DienTich = dienTich;
          
        }
        public virtual int getAttributeSCount()
        {
            return 4;
        }

        public virtual int getSoTang()
        {
            return 0;
        }
        public virtual int getNamXayDung()
        {
            return 0;
        }
    }
}
