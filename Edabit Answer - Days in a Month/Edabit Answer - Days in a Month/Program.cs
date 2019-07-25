using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit_Answer___Days_in_a_Month
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Days(2, 2018));
            Console.WriteLine(Days(3, 2011));
            Console.WriteLine(Days(4, 654));
            Console.WriteLine(Days(2, 2020));
            Console.WriteLine(Days(2, 200));
            Console.WriteLine(Days(2, 1000));
            Console.Read();


        }

        public static int Days(int month, int year)
        {
            var result = System.DateTime.DaysInMonth(year, month);
            return result;
        }
    }
}
