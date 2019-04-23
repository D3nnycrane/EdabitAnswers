using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit_ReturnPlusOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Addition(3));
            Console.WriteLine(Addition(12));
            Console.WriteLine(Addition(1));
            Console.Read();
        }

        public static int Addition(int num)
        {
            return num + 1;
        }
    }
}
