using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit_Answer___Find_the_Index
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindIndex(new string[] { "hi", "edabit", "fgh", "abc" }, "fgh"));
            Console.WriteLine(FindIndex(new string[] { "Red", "blue", "Blue", "Green" }, "blue"));
            Console.WriteLine(FindIndex(new string[] { "a", "g", "y", "d" }, "d"));
            Console.WriteLine(FindIndex(new string[] { "Pineapple", "Orange", "Grape", "Apple" }, "Pineapple"));
            Console.Read();
        }

        public static int FindIndex(string[] arr, string str)
        {
            var index = Array.IndexOf(arr, str);
            return index;
        }

    }
}
