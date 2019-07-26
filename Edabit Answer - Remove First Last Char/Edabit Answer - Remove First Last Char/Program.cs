using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit_Answer___Remove_First_Last_Char
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RemoveFirstLast("hello"));
            Console.WriteLine(RemoveFirstLast("maybe"));
            Console.WriteLine(RemoveFirstLast("benefit"));
            Console.WriteLine(RemoveFirstLast("a"));
            Console.Read();

        }

        public static string RemoveFirstLast(string str)
        {
            if (str.Length <= 2)
                return str;

            string myString = "";
            myString = str.Substring(1, str.Length - 2);
            return myString;
        }
    }
}
