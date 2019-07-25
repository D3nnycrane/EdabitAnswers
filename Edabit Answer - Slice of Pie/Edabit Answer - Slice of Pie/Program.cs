using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit_Answer___Slice_of_Pie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(EqualSlices(11, 5, 2));
            Console.WriteLine(EqualSlices(11, 5, 3));
            Console.WriteLine(EqualSlices(8, 3, 2));
            Console.WriteLine(EqualSlices(8, 3, 3));
            Console.WriteLine(EqualSlices(24, 12, 2));
            Console.Read();
        }

        public static bool EqualSlices(int total, int people, int each)
        {
            var result = people * each;
            if (result <= total)
            {
                return true;
            }
            else
                return false;
        }
    }
}
