using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit_Answer___Return_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Remainder(4, 9));
            Console.WriteLine(Remainder(2, 11));
            Console.WriteLine(Remainder(3, 19));
            Console.ReadLine();
        }

        public static int Remainder(int x, int y)
        {
            int z = x % y;
            return z;
        }
    }
}
