using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit_Answer___Missing_Third_Angle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MissingAngle(12, 27));
            Console.WriteLine(MissingAngle(45, 45));
            Console.WriteLine(MissingAngle(120, 13));
            Console.WriteLine(MissingAngle(22, 22));
            Console.WriteLine(MissingAngle(45, 49));
            Console.Read();
        }

        public static string MissingAngle(int angle1, int angle2)
        {
            var angle3 = "";
            if (angle1 + angle2 < 90)
            {
                angle3 = "obtuse";
            }
            if (angle1 + angle2 == 90)
            {
                angle3 = "right";
            }
            if(angle1 + angle2 > 90)
            {
                angle3 = "acute";
            }
            return angle3;
        }
    }
}
