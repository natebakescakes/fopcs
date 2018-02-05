using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fopcs_day2
{
    class Lecture
    {
        public static void Work1()
        {
            // ------------------ Integer Operation ------------------
            int a = 5;
            int b = 3;
            Console.WriteLine(5 * 3); // 15

            int c = 5 - 3;
            Console.WriteLine(c); // 2

            Console.WriteLine(a / b); // 1 (integer division)
            Console.WriteLine(a % b); // 2 (remainer of 5 divided by 3)

            // ------------------ Double Operation ------------------
            double aa = 5.0;
            double bb = 3.0;

            Console.WriteLine(aa * bb); // 15
            Console.WriteLine(aa - bb); // 2

            Console.WriteLine(aa / bb); // 1.6667 (recurring)

            Console.WriteLine(a / 2); // 2 (both integers)
            Console.WriteLine(a / 2.0); // 2.5 (one non-integer)
            Console.WriteLine((double) a / 2); // 2.5 (type casting to force decimal display)

            Console.WriteLine(aa % bb); // 2 (remainder for double)
        }

        public static void Work2()
        {
            int a = 5; // initialise a to 5
            int b = 3;

            Console.WriteLine(+a); // 5
            Console.WriteLine(-a); // -5
            
            int c = ++a; // increment a, assign the result into c
            Console.WriteLine(c); // 6
            Console.WriteLine(a); // 6

            a = 5; // reset a to 5

            int d = a++; // assign a to d and afterwards increment a
            Console.WriteLine(d); // 5
            Console.WriteLine(a); // 6
        }

        public static void Work3()
        {
            int a = 5;
            int b = 3;

            Console.WriteLine(10 - 5 / a); // 9
            Console.WriteLine(10 - 5 / -a); // 11

            Console.WriteLine(10 - (5 / a)); // 9
            Console.WriteLine((10 - 5) / a); // 1
        }

        public static void Work4()
        {
            int a = 5;
            int b = 3;

            Console.WriteLine(a == b); // False
            bool c = (a != b);
            Console.WriteLine(c); // True

            Console.WriteLine(a < a); // False

            Console.WriteLine((b > 1) && (a > 10)); // False
            Console.WriteLine((b > 1) & (a > 10)); // False (& still treated as && for C# if both left and right expressions are bool)

            Console.WriteLine(Math.Max(a, b)); // a (Returns higher of the two values passed in as arguments)
            Console.WriteLine(Math.Min(a, b)); // b (Returns lower of the two values passed in as arguments)

            Console.WriteLine(Math.Ceiling(2.3)); // 3 (Rounds up to the next integer)
            Console.WriteLine(Math.Round(2.35671)); // 2 (Rounds to the nearest integer)
            Console.WriteLine(Math.Round(2.35671, 2)); // 2.36 (Rounds to nearest 2 decimal places)
        }
    }
}
