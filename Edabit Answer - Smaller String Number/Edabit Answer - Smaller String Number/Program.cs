using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit_Answer___Smaller_String_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(smallerNum("21", "44"));
            Console.WriteLine(smallerNum("1500", "1"));
            Console.WriteLine(smallerNum("5", "5"));
            Console.Read();
        }

        public static string smallerNum(string n1, string n2)
        {
            if (int.Parse(n1) < int.Parse(n2))
                return n1;
            else
                return n2;
        }
    }
}
