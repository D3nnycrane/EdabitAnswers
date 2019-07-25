using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit_Answer___Hurdle_Jump
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[] { 1, 2, 3, 4, 5 };
            int[] array2 = new int[] { 5, 5, 3, 4, 5 };
            int[] array3 = new int[] { 5, 4, 5, 6 };
            int[] array4 = new int[] { 1, 2, 1 };

            Console.WriteLine(hurdleJump(array1, 5));
            Console.WriteLine(hurdleJump(array2, 3));
            Console.WriteLine(hurdleJump(array3, 10));
            Console.WriteLine(hurdleJump(array4, 1));

            Console.Read();
        }

        public static bool hurdleJump(int[] hurdles, int jumpHeight)
        {
            if (hurdles.Length == 0)
            {
                return true;
            }
            return jumpHeight >= hurdles.Max();
        }
    }
}
