static int tinhTongSoLe(params int[] mang)
{
    int tong = 0;
    foreach(int n in mang)
    {
        if (n % 2 != 0)
            tong += n;
    }
    return tong;
}
int tongCacSoLe = tinhTongSoLe(1, 2, 3);
Console.WriteLine("Tong cac so le:"+tongCacSoLe);

static bool kiemTraSoNguyenTo(int n)
{
    if (n < 2)
        return false;
    for (int i = 2; i <= Math.Sqrt( n); ++i)
        if (n % i == 0)
            return false;
    return true;
}
static int demCacSoNguyenTo(params int[ ] mang)
{
    int soCacSoNguyenTo = 0;
    foreach (int n in mang)
    {
        if(kiemTraSoNguyenTo(n))
            soCacSoNguyenTo++;
    }
    return soCacSoNguyenTo; ;
}
int soCacSoNguyenT0 = demCacSoNguyenTo(1,2,3);
Console.WriteLine("Cac so nguyen to trong mang:"+ soCacSoNguyenT0);

static bool kiemTraSoChinhPhuong(int n)
{
    int sqr =(int) Math.Sqrt(n);
    return (sqr * sqr == n);
}
static int timSoChinhPhuongDauTien(params int[ ] mang)
{
    foreach(int n in mang)
    {
        if (kiemTraSoChinhPhuong(n))
            return n;
    }
    return -1;
}
static int timSoChinhPhuongNhoNhat(params int[] mang)
{
    int soChinhPhuongNhoNhat = timSoChinhPhuongDauTien(mang);
    if (soChinhPhuongNhoNhat == -1)
        return -1;
    foreach(int n in mang)
        {
            if (kiemTraSoChinhPhuong(n))
                if(soChinhPhuongNhoNhat > n)
                soChinhPhuongNhoNhat = n;
        }
    return soChinhPhuongNhoNhat;
    
}
int soChinhPhuongNhoNhat = timSoChinhPhuongNhoNhat(16,5,3);
Console.WriteLine("So chinh phuong nho nhat:" + soChinhPhuongNhoNhat);
