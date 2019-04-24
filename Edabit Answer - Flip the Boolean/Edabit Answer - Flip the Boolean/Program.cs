using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit_Answer___Flip_the_Boolean
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Reverse(true));
            Console.WriteLine(Reverse(true));
            Console.WriteLine(Reverse(false));
            Console.WriteLine(Reverse(false));
            Console.WriteLine(Reverse(true));
            Console.Read();
        }

        public static bool Reverse(bool boolean)
        {
            if (boolean == true)
                return false;
            else
                return true;
        }
    }
}
