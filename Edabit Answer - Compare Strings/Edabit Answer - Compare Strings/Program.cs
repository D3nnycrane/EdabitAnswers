using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit_Answer___Compare_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Comp("Dick", "Head"));
            Console.WriteLine(Comp("Ass", "face"));
            Console.WriteLine(Comp("Dick", "Cock"));
            Console.WriteLine(Comp("Braphog", "Tootlets"));
            Console.Read();
        }

        public static bool Comp(string str1, string str2)
        {
            if (str1.Length == str2.Length)
                return true;
            else
                return false;
        }
    }
}
