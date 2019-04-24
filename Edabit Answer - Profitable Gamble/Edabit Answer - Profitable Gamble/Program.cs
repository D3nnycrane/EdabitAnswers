using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit_Answer___Profitable_Gamble
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ProfitableGamble(12, 1, 11));
            Console.WriteLine(ProfitableGamble(13, 2, 29));
            Console.Read();
        }

        public static bool ProfitableGamble(double prob, int prize, double pay)
        {
            if ((prob * prize) > pay)
                return true;
            else
                return false;
        }
    }
}
