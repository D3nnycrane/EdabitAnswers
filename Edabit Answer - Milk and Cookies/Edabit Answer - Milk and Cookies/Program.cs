using System;

namespace Edabit_Answer___Milk_and_Cookies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(TimeForMilkAndCookies(2019, 12, 24));
            Console.WriteLine(TimeForMilkAndCookies(2019, 08, 22));
            Console.WriteLine(TimeForMilkAndCookies(1985, 12, 24));
            Console.Read();
        }

        public static bool TimeForMilkAndCookies(int year, int month, int day)
        {
            if (month == 12 && day == 24)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
