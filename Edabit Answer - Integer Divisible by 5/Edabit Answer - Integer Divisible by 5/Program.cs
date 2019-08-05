using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit_Answer___Integer_Divisible_by_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(divisibleByFive(5));
            Console.WriteLine(divisibleByFive(-55));
            Console.WriteLine(divisibleByFive(37));
            Console.Read();
        }

        public static bool divisibleByFive(int n)
        {
            bool result = (n % 5 == 0) ? true : false;
            return result;
        }
    }
}
