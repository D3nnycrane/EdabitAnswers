using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit___Convert_Number_to_Dashes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Go(5));
            Console.WriteLine(Go(3));
            Console.WriteLine(Go(15));
            Console.WriteLine(Go(9));
            Console.WriteLine(Go(11));
            Console.Read();
        }

        public static string Go(int num)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append('-', num);
            return sb.ToString();
        }
    }
}
