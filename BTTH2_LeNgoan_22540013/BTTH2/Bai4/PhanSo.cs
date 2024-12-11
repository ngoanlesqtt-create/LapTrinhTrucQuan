using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class PhanSo
    {
        public int TuSo {  get; set; }
        public int MauSo { get; set; }

        public void Rutgon()
        {
            int a = this.TuSo;
            int b = this.MauSo;
            int ucln;
            if (a < 0)
            {
                a = a * (-1);
            }
            if (b < 0)
            {
                b = b * (-1);
            }
            if (a == 0)
            {
                ucln = a + b;
            }
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            ucln = a;
            this.TuSo /= ucln;
            this.MauSo /= ucln;
        }
        public static PhanSo operator+(PhanSo a, PhanSo b)
        {
            PhanSo c=new PhanSo();
            c.MauSo = a.MauSo * b.MauSo;
            c.TuSo = a.TuSo * b.MauSo + b.TuSo * a.MauSo;
            c.Rutgon();
            return c;
        }
        public static PhanSo operator-(PhanSo a, PhanSo b)
        {
            PhanSo c = new PhanSo();
            c.MauSo = a.MauSo * b.MauSo;
            c.TuSo = a.TuSo * b.MauSo - b.TuSo * a.MauSo;
            c.Rutgon();
            return c;
        }
        public static PhanSo operator*(PhanSo a, PhanSo b)
        {
            PhanSo c = new PhanSo();
            c.TuSo = a.TuSo * b.TuSo;
            c.MauSo=a.MauSo*b.MauSo;
            c.Rutgon();
            return c;
        }
        public static PhanSo operator/(PhanSo a, PhanSo b)
        {
            PhanSo c = new PhanSo();
            c.TuSo = a.TuSo * b.MauSo;
            c.MauSo = a.MauSo * b.TuSo;
            c.Rutgon();
            return c;
        }
        public static bool operator>(PhanSo a, PhanSo b)
        {
            PhanSo c = a - b;
            if(c.TuSo/c.MauSo>0)
                return true;
            return false;
        }

        public static bool operator<(PhanSo a, PhanSo b)
        {
            bool ketQua = a > b;
            if(ketQua)
                return false;
            return true;
        }
    }
}
