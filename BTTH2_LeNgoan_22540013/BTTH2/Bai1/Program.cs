Console.WriteLine("Nhap thang:");
int thang = int.Parse(Console.ReadLine());

Console.WriteLine("Nhap nam:");
int nam = int.Parse(Console.ReadLine());

DateTime date = new DateTime(nam, thang, 1);

string[,] calendar = new string[5, 7];

int soNgayTrongThang = DateTime.DaysInMonth(nam, thang);
int ngayDauTrongThang = (int)date.DayOfWeek;

int trungGian = 1;
for (int i = 0; i < 5; ++i)
    for (int j = 0; j < 7; j++)
        if (j < ngayDauTrongThang && i == 0)
            calendar[0, j] = "  ";
        else
        {
            if (trungGian < 10)
                calendar[i, j] = " " + trungGian.ToString();
            else calendar[i, j] = trungGian.ToString();
            trungGian++;
            if (trungGian > soNgayTrongThang)
                break;
        }

Console.WriteLine("Su Mo Tu We Th Fr Sa");

for (int i = 0; i < 5; ++i)
{
    for (int j = 0; j < 7; j++)
        Console.Write(calendar[i, j] + " ");
    Console.WriteLine();
}
//class Program
//{
//    static void Main()
//    {
//        // Nhập tháng và năm từ người dùng
//        Console.Write("Nhập tháng (1-12): ");
//        int month = int.Parse(Console.ReadLine());

//        Console.Write("Nhập năm: ");
//        int year = int.Parse(Console.ReadLine());

//        // Kiểm tra xem tháng có hợp lệ không
//        if (month < 1 || month > 12)
//        {
//            Console.WriteLine("Tháng không hợp lệ. Vui lòng nhập tháng từ 1 đến 12.");
//            return;
//        }

//        // In tiêu đề tháng và năm
//        Console.WriteLine($"\n     {GetMonthName(month)} {year}");
//        Console.WriteLine("Mo Tu We Th Fr Sa Su");

//        // Lấy ngày đầu tiên của tháng
//        DateTime firstDay = new DateTime(year, month, 1);
//        int daysInMonth = DateTime.DaysInMonth(year, month);

//        // In khoảng trắng cho các ngày trước ngày đầu tiên
//        for (int i = 1; i < (int)firstDay.DayOfWeek + 1; i++)
//        {
//            Console.Write("   ");
//        }

//        // In các ngày trong tháng
//        for (int day = 1; day <= daysInMonth; day++)
//        {
//            Console.Write($"{day,2} ");
//            if ((day + (int)firstDay.DayOfWeek) % 7 == 0) // Đưa xuống dòng sau mỗi 7 ngày
//            {
//                Console.WriteLine();
//            }
//        }
//    }

//    // Hàm để lấy tên tháng
//    static string GetMonthName(int month)
//    {
//        return new DateTime(2021, month, 1).ToString("MMMM");
//    }
//}