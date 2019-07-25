using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit_Answer___The_Farm_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(animals(3, 5, 6));
            Console.WriteLine(animals(1, 2, 23));
            Console.WriteLine(animals(7, 8, 9));
            Console.WriteLine(animals(5, 12, 13));
            Console.Read();
        }

        public static int animals(int chickens, int cows, int pigs)
        {
            var chickenLegs = 2;
            var cowLegs = 4;
            var pigLegs = 4;
            var answer = (chickens * chickenLegs) + (cows * cowLegs) + (pigs * pigLegs);
            return answer;
        }
    }
}
