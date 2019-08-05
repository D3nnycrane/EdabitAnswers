using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit_Answer___Repeating_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DoubleChar("Tester"));
            Console.WriteLine(DoubleChar("Cowabunga"));
            Console.WriteLine(DoubleChar("Adinosinetriphosphate"));
            Console.WriteLine(DoubleChar("Dweeb"));
            Console.Read();
        }

        public static string DoubleChar(string str)
        {
            return String.Concat(str.Select(c => c.ToString() + c.ToString()));
        }
    }
}
