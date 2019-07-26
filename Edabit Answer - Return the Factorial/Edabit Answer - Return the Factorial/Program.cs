using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit_Answer___Return_the_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(3));
            Console.WriteLine(Factorial(5));
            Console.WriteLine(Factorial(13));
            Console.Read();
        }

        public static int Factorial(int num)
        {
            int fact = num;
            for (int i = num - 1; i >= 1; i--)
            {
                fact = fact * i;
            }
            return fact;
        }
    }
}
