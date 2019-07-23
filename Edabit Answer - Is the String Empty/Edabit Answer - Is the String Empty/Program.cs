using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit_Answer___Is_the_String_Empty
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isEmpty(""));
            Console.WriteLine(isEmpty("Not Empty"));
            Console.WriteLine(isEmpty(" "));
            Console.WriteLine(isEmpty(""));
            Console.ReadLine();
        }

        public static bool isEmpty(string str)
        {
            if (String.IsNullOrEmpty(str))
                return true;
            else
                return false;
        }
    }
}
