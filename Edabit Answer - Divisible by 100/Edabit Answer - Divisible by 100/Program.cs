using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit_Answer___Divisible_by_100
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Divisible(100));
            Console.WriteLine(Divisible(101));
            Console.WriteLine(Divisible(1000));
            Console.WriteLine(Divisible(7));
            Console.WriteLine(Divisible(10000));
            Console.Read();
        }

        public static bool Divisible(int number)
        {
            
            if (number % 100 == 0)
            {
                return true;
            }
            else
                return false;
        }
    }
}
