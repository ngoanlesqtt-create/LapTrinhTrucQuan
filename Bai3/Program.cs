String dayString=Console.ReadLine(); 
int day=Convert.ToInt32(dayString);

String mongthString=Console.ReadLine(); ;
int month=Convert.ToInt32(mongthString);

String yearString=Console.ReadLine(); 
int year=Convert.ToInt32(yearString);

static bool verifyYear(int year)
{
    return year < 0 ? false : true;
}
static bool checkMonth(int[] months, int month)
{
    foreach (int n in months)
        if(n == month) return true;
    return false;

}
static bool verifyMonth(int month)
{
    int[] mongthsOf30Days = { 4, 6, 9, 11 };
    int[] mongthsOf31Days = { 1, 3, 5, 7, 8, 10, 12 };
    return checkMonth(mongthsOf30Days, month) || checkMonth(mongthsOf31Days, month) || month == 2 ? true : false;
}
static bool verifyDay(int ngay, int month, int year)
{
    int[] mongthsOf30Days = { 4, 6, 9, 11 };
    int[] mongthsOf31Days = { 1, 3, 5, 7, 8, 10, 12 };
    if(checkMonth(mongthsOf30Days, month))
    {
        if (ngay >= 1 && ngay <= 30)
            return true;
    }else if(checkMonth(mongthsOf31Days, month))
        if(ngay >= 1 &&ngay<=31)
            return true;
   else if (month == 2)
    {
        if (year % 400==0 )
            if (ngay >= 1 && ngay <= 29)
                return true;
        if (ngay >= 1 && ngay <= 28)
            return true;
    }
    return false;
}
if (verifyYear(year))
{
    if (verifyMonth(month))
    {
        if (verifyDay(day, month, year))
        {

            Console.WriteLine("Ban da nhap dung");
        }
        else Console.WriteLine("Ban da nhap sai ngay");

    }
    else Console.WriteLine("Ban da nhap sai thang");

}
else Console.WriteLine("Ban da nhap sai nam");