namespace BaiTap1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime x;
            Console.Write(" - Month: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write(" - Year: ");
            int year = int.Parse(Console.ReadLine());
            while (!checkValid(month, year))
            {
                Console.Clear();
                Console.WriteLine("Month or year is invalid. Please try again!");
                Main(args);
            }
            Console.Clear();
            x = new DateTime(year, month, 1);
            printDayOfWeek();
            printDate(x, month, year);
            Console.ReadKey();
        }
        static bool isYear(int x)
        {
            if (x < 1)
                return false;
            return true;
        }
        static bool isMonth(int x)
        {
            if (x < 1 || x > 12)
                return false;
            return true;
        }
        static bool checkValid(int m, int y)
        {
            if (isYear(y) && isMonth(m))
                return true;
            return false;
        }
        static int getDate(DateTime m, int markPoint)
        {
            DateTime x;
            for (int i = 1; i < 8; i++)
            {
                x = new DateTime(1, 4, i);
                if (m.DayOfWeek == x.DayOfWeek)
                    return int.Parse(x.ToString("dd")) - 1;
            }
            return -1;
        }
        static void printDate(DateTime x, int month, int year)
        {
            for (int i = 1; i <= getDate(x, x.Day) + DateTime.DaysInMonth(year, month); i++)
            {
                if (i <= getDate(x, x.Day))
                    Console.Write("     ");
                else
                {
                    if (i - getDate(x, x.Day) < 10)
                        Console.Write("0{0}   ", i - getDate(x, x.Day));
                    else Console.Write("{0}   ", i - getDate(x, x.Day));
                }
                if (i % 7 == 0)
                    Console.WriteLine();
            }
        }
        static void printDayOfWeek()
        {
            DateTime temp;
            for (int i = 1; i < 8; i++)
            {
                temp = new DateTime(1, 4, i);
                string dateTemp = (temp.DayOfWeek.ToString()[0].ToString() + temp.DayOfWeek.ToString()[1].ToString() + temp.DayOfWeek.ToString()[2].ToString()).ToUpper();
                Console.Write(dateTemp + "  ");
            }
            Console.WriteLine();
        }
    }
}
