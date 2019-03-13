using System;

namespace Edabit_Answer____Number_less_than_or_equal_to_zero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The value of 0 is {0}", LessThanOrEqualToZero(0));
            Console.WriteLine("The value of 5 is {0}", LessThanOrEqualToZero(5));
            Console.WriteLine("The value of -2 is {0}", LessThanOrEqualToZero(-2));

            Console.ReadLine();

        }

        public static bool LessThanOrEqualToZero(double a)
        {
            if (a <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
