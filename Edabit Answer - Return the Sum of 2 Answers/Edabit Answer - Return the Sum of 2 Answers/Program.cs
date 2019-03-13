using System;

namespace Edabit_Answer___Return_the_Sum_of_2_Answers
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Sum(2, 2);
            Console.WriteLine($"The answer is {result}.");
            Console.Read();

        }

        public static int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
