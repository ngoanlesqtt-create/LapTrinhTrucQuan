String mongthString = Console.ReadLine(); ;
int month = Convert.ToInt32(mongthString);

String yearString = Console.ReadLine();
int year = Convert.ToInt32(yearString);

static bool verifyYear(int year)
{
    return year >=0?true:false; 
}
static bool verifyMonth(int month,int[] months) {
    foreach (int n in months) {
        if (n == month) return true;
    }
    return false;
}
static void printDayOfMonth(int month,int year)
{
    int[] mongthsOf30Days = { 4, 6, 9, 11 };
    int[] mongthsOf31Days = { 1, 3, 5, 7, 8, 10, 12 };


    if (verifyMonth(month, mongthsOf30Days))
        Console.WriteLine("thang " + month + " co 30 ngay");
    else if (verifyMonth(month, mongthsOf31Days))
        Console.WriteLine("thang "+month+" co 31 ngay");
    else if (month == 2)
    {
        if (year % 400 == 0)
            Console.WriteLine("thang 2 nam " + year + " co 29 ngay");
        else Console.WriteLine("thang 2 nam "+year+" co 28 ngay");
    }
}
if (verifyYear(year))
    printDayOfMonth(month, year);
else Console.WriteLine("Ban da nhap sai nam");