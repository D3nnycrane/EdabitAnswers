using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit_Answers___Hacker_Speak
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HackerSpeak("javascript is cool"));
            Console.WriteLine(HackerSpeak("programming is fun"));
            Console.WriteLine(HackerSpeak("become a coder"));
            Console.Read();
        }

        public static string HackerSpeak(string str)
        {
            return str.Replace("a", "4").Replace("e", "3").Replace("i", "1").Replace("o", "0").Replace("s", "5");
        }
    }
}
