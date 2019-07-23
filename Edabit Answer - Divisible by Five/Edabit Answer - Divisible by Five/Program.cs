using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit_Answer___Divisible_by_Five
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(divisibleByFive(55));
            Console.WriteLine(divisibleByFive(43));
            Console.WriteLine(divisibleByFive(15));
            Console.WriteLine(divisibleByFive(22));
            Console.WriteLine(divisibleByFive(100));
            Console.ReadLine();
        }

        public static bool divisibleByFive(int n)
        {
            if (n % 5 == 0)
            {
                return true;
            }
            else
                return false;
        }
    }
}
