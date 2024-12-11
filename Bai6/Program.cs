using System;
using System.Diagnostics;

int n = 5;
int m = 4;

int[,] matrix = new int[n, m];

static void initMatrix(int[,] matrix, int n, int m)
{
    int value;
    Random random = new Random();
    for (int i = 0; i < n; ++i)
        for (int j = 0; j < m; ++j)
        {
            value = random.Next(20);
            matrix[i, j] = value;
        }
}
static void printMatrix(int[,] matrix, int n, int m)
{
    initMatrix(matrix, n, m);
    for (int i = 0; i < n; ++i)
    {
        for (int j = 0; j < m; ++j)
        {
            Console.Write("\t" + matrix[i, j]);
        }
        Console.WriteLine();
    }
}
static int timPhanTuLonNhat(int[,] matrix)
{
    int phanTuLonNhat = matrix[0, 0];
    int n = matrix.GetLength(0);
    int m = matrix.GetLength(1);
    for (int i = 0; i < n; ++i)
        for (int j = 0; j < m; ++j)
            if (phanTuLonNhat < matrix[i, j])
                phanTuLonNhat = matrix[i, j];
    return phanTuLonNhat;
}
static int timPhanTuNhoNhat(int[,] matrix)
{
    int phanTuLonNhat = matrix[0, 0];
    int n = matrix.GetLength(0);
    int m = matrix.GetLength(1);
    for (int i = 0; i < n; ++i)
        for (int j = 0; j < m; ++j)
            if (phanTuLonNhat > matrix[i, j])
                phanTuLonNhat = matrix[i, j];
    return phanTuLonNhat;
}
static int timTongLonNhat(int[] sumOfCols)
{
    int tongLonNhat = sumOfCols[0];
    foreach (int n in sumOfCols)
        if (tongLonNhat < n)
            tongLonNhat = n;
    return tongLonNhat;

}
static int timDongLonNhat(int[,] matrix)
{
    int n = matrix.GetLength(0);
    int m = matrix.GetLength(1);
    int[] sumOfCols = new int[n];
    int tong;
    for (int i = 0; i < n; ++i)
    {
        tong = 0;
        for (int j = 0; j < m; ++j)
        {
            tong += matrix[i, j];
        }
        sumOfCols[i] = tong;
    }
    int dongTong = sumOfCols.Length;
    for (int i = 0; i < dongTong; ++i)
        if (sumOfCols[i] == timTongLonNhat(sumOfCols))
            return i;
    return 0;

}
static bool isPrime(int n)
{
    if (n < 2)
        return false;
    for (int i = 2; i <= Math.Sqrt(n); ++i)
        if (n % i == 0)
            return false;
    return true;

}
static int tinhTongCacSoKhongLaNguyenTo(int[,] matrix)
{
    int tong = 0;
    int n = matrix.GetLength(0);
    int m = matrix.GetLength(1);
    for (int i = 0; i < n; ++i)
        for (int j = 0; j < m; ++j)
            if (!isPrime(matrix[i, j]))
                tong += matrix[i, j];
    return tong;
}
static int[,] xoaDongThuK(int[,] matrix, int k)
{
    int n = matrix.GetLength(0);
    int m = matrix.GetLength(1);
    int[,] newMatrix = new int[n - 1, m];
    if (k > n - 1)
        return matrix;
    if (k == n - 1)
    {
        for (int i = 0; i < n - 1; ++i)
            for (int j = 0; j < m; ++j)
                newMatrix[i, j] = matrix[i, j];

    }
    else if (k == 0)
    {
        for (int i = 0; i < n - 1; ++i)
            for (int j = 0; j < m; ++j)
                newMatrix[i, j] = matrix[i + 1, j];
    }

    else if (k < n - 1)
        for (int i = 0; i < n - 1; ++i)
            for (int j = 0; j < m; ++j)
            {
                if (i < k)
                {
                    newMatrix[i, j] = matrix[i, j];
                }
                else
                {
                    newMatrix[i, j] = matrix[i + 1, j];
                }

            }
    return newMatrix;
}
static void printNewMatrix(int[,] matrix)
{
    int n = matrix.GetLength(0);
    int m = matrix.GetLength(1);
    for (int i = 0; i < n; ++i)
    {
        for (int j = 0; j < m; ++j)
            Console.Write("\t" + matrix[i, j]);
        Console.WriteLine();
    }
}
static bool kiemTraTrungTrongDSCot(List<int> cacCotCoPhanTuLonNhat, int j)
{
    if (cacCotCoPhanTuLonNhat.Count == 0)
        return true;
    foreach (int i in cacCotCoPhanTuLonNhat)
        if (i == j)
            return false;
    return true;
}
static List<int> timCacCotCoPhanTuLonNhat(int[,] matrix)
{
    int n = matrix.GetLength(0);
    int m = matrix.GetLength(1);
    int phanTuLonNhat = timPhanTuLonNhat(matrix);
    List<int> cacCotCoPhanTuLonNhat = new List<int>();
    for (int i = 0; i < n; ++i)
        for (int j = 0; j < m; ++j)
            if (matrix[i, j] == phanTuLonNhat)
                if (kiemTraTrungTrongDSCot(cacCotCoPhanTuLonNhat, j))
                    cacCotCoPhanTuLonNhat.Add(j);
    return cacCotCoPhanTuLonNhat;
}

static int[,] xoaCacCotCoPhanTuLonNhat(int[,] matrix)
{
    List<int> cacCotCoPhanTuLonNhat = timCacCotCoPhanTuLonNhat(matrix);
    int n = matrix.GetLength(0);
    int m = matrix.GetLength(1);
    int k = m - cacCotCoPhanTuLonNhat.Count;
    if (k == 0)
        return matrix;
    int[,] newMatrix = new int[n, k];
    int index = 0;

    for (int j = 0; j < m; ++j)
        if (kiemTraTrungTrongDSCot(cacCotCoPhanTuLonNhat, j))
        {
            for (int i = 0; i < n; ++i)
                newMatrix[i, index] = matrix[i, j];

            index++;
        }
    return newMatrix;
}
printMatrix(matrix, n, m);
int phanTuNhoNhat = timPhanTuNhoNhat(matrix);
int phanTuLonNhat = timPhanTuLonNhat(matrix);
Console.WriteLine("Phan tu nho nhat:" + phanTuNhoNhat);
Console.WriteLine("Phan tu lon nhat:" + phanTuLonNhat);
int dongCoTongLonNhat = timDongLonNhat(matrix);
Console.WriteLine("Dong co tong lon nhat:" + dongCoTongLonNhat);
int tongCacSoKhongLaNguyenTo = tinhTongCacSoKhongLaNguyenTo(matrix);
Console.WriteLine("Tong cac so khong la nguyen to:" + tongCacSoKhongLaNguyenTo);
Console.WriteLine("Xoa dong:");
matrix = xoaDongThuK(matrix, 4);
printNewMatrix(matrix);
Console.WriteLine("Xoa cot:");
matrix = xoaCacCotCoPhanTuLonNhat(matrix);
printNewMatrix(matrix);
