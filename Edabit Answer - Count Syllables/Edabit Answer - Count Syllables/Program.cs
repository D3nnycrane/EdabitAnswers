using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit_Answer___Count_Syllables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumberSyllables("buf-fet"));
            Console.WriteLine(NumberSyllables("beau-ti-ful"));
            Console.WriteLine(NumberSyllables("mon-u-men-tal"));
            Console.WriteLine(NumberSyllables("on-o-mat-o-poe-ia"));
            Console.Read();
        }

        public static int NumberSyllables(string word)
        {
            int count = 0;
            string[] split = word.Split('-');
            foreach (string s in split)
            {
                if (s.Trim() != "")
                    count++;
            }
            return count;
        }
    }
}
