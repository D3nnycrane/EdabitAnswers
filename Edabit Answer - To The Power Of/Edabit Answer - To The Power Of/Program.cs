using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit_Answer___To_The_Power_Of
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalculateExponent(5, 5));
            Console.WriteLine(CalculateExponent(10, 10));
            Console.WriteLine(CalculateExponent(3, 3));
            Console.Read();
        }

        public static long CalculateExponent(long number, long exponent)
        {
            return (long) (Math.Pow(number, exponent));
        }
    }
}
