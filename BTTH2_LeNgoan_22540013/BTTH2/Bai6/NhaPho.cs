using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    internal class NhaPho:SanPham
    {
        public NhaPho( string diaDiem, int giaBan, double dienTich, int namXayDung, int soTang) : base(diaDiem, giaBan, dienTich)
        {
            this.NamXayDung = namXayDung;
            this.SoTang = soTang;

        }

        public int NamXayDung {  get; set; }
        public int SoTang {  get; set; }
        public override int getAttributeSCount()
        {
            return 6;
        }
        public override int getSoTang()
        {
            return this.SoTang;
        }
        public override int getNamXayDung()
        {
            return this.NamXayDung;
        }
    }
}
