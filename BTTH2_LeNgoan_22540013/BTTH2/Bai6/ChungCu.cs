using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    internal class ChungCu:SanPham
    {
        public int Tang {  get; set; }
        public ChungCu(string diaDiem, int giaBan, double dienTich, int tang) : base(diaDiem, giaBan, dienTich)
        {
            this.Tang = tang;
        }
        public override int getAttributeSCount()
        {
            return 5;
        }
        public override int getSoTang()
        {
            return this.Tang;
        }
    }
}
