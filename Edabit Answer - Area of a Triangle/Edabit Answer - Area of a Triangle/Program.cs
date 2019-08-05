using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit_Answer___Area_of_a_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(triArea(3, 2));
            Console.WriteLine(triArea(7, 4));
            Console.WriteLine(triArea(10, 10));
            Console.Read();
        }

        public static int triArea(int b, int h)
        {
            return (b * h) / 2;
        }
    }
}
