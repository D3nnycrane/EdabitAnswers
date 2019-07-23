using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit_Answer___Difference_in_Array_Max_Min
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[] { 74, 12, 44, 91, 8 };
            int[] array2 = new int[] { 8, 1, 12, -9, 14 };
            Console.WriteLine("The difference between max and min is: {0}", differenceMaxMin(array1));
            Console.WriteLine("The difference between max and min is: {0}", differenceMaxMin(array2));
            Console.ReadLine();
        }

        public static int differenceMaxMin(int[] arr)
        {
            Array.Sort(arr);
            int min = arr.Max();
            int max = arr.Min();
            return min - max;
        }
    }
}
