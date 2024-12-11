Console.WriteLine("Nhap so n:");
String nString = Console.ReadLine();
int n=Convert.ToInt32(nString);
static bool kiemTraSoNguyenTo(int n)
{
    if (n < 2)
        return false;
    for (int i = 2; i <= Math.Sqrt(n); ++i)
        if (n % i == 0) return false;
    return true;
}

static int tinhTongSoNguyenTo(int n)
{
    int tong = 0;
    int m = n + 1;
    for (int i = 2; i < m; ++i)
        if (kiemTraSoNguyenTo(i))
        {
            Console.WriteLine("i="+i);
            tong += i;
        }
    return tong;    
}
int tongSoNguyenTo = tinhTongSoNguyenTo(n);
Console.WriteLine("Tong so nguyen to:" + tongSoNguyenTo);

