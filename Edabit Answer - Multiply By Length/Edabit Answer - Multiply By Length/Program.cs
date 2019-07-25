using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit_Answer___Multiply_By_Length
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static int[] MultiplyByLength(int[] arr)
        {
            var multiplier = arr.Length;
            return arr.Select(x => x * multiplier).ToArray();
        }
    }
}
