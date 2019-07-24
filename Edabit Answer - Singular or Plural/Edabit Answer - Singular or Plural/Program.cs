using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit_Answer___Singular_or_Plural
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPlural("Egg"));
            Console.WriteLine(IsPlural("Eggs"));
            Console.WriteLine(IsPlural("Chicken"));
            Console.WriteLine(IsPlural("Chickens"));
            Console.Read();
        }

        public static bool IsPlural(string word)
        {
            if (word.EndsWith("s"))
            {
                return true;
            }
            else
                return false;
        }
    }
}
