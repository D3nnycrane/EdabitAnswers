using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit_Answer___Concatenate_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ConcatName("Father", "Ted"));
            Console.WriteLine(ConcatName("Freddie", "Mercury"));
            Console.WriteLine(ConcatName("Jesus", "Christ"));
            Console.WriteLine();
        }

        public static string ConcatName(string firstName, string lastName)
        {
            return lastName + ", " + firstName;
        }
    }
}
