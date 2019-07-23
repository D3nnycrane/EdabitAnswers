using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit_Answer___Check_String_for_Spaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HasSpaces("nospaceshere"));
            Console.WriteLine(HasSpaces("Spaces right here!"));
            Console.WriteLine(HasSpaces("NOSPACESHERE"));
            Console.WriteLine(HasSpaces(" "));
            Console.ReadLine();
        }

        public static bool HasSpaces(string str)
        {
            if (str.Contains(" "))
            {
                return true;
            }
            else
                return false;
        }
    }
}
