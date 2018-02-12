using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalExercises
{
    public class PrintParticularPattern
    {
        public static void Question6a()
        {
            string s = "";

            for (int i = 0; i < 6; i++)
            {
                s += "*";
                Console.WriteLine(s);
            }
        }

        public static void Question6b()
        {
            string s = "";

            for (int i = 0; i < 6; i++)
            {
                s += "*";
                Console.WriteLine($"{s,60}");
            }
        }

        public static void Question6c()
        {
            string stars = "";

            for (int i = 0, j = 60; i < 6; i++, j -= (i % 2 == 0 ? 1 : 0))
            {
                stars += "*";
                String spaces = new String(' ', j);
                Console.WriteLine($"{spaces}{stars}");
            }
        }

        public static void Question7()
        {
            for (int i = 6, j = 60; i >= 0; i--, j += (i % 2 == 0 ? 1 : 0))
            {
                String stars = new string('*', i);
                String spaces = new string(' ', j);
                Console.WriteLine($"{spaces}{stars}");
            }
        }

        public static void Question8()
        {
            for (int i = 1; i < 6; i++)
            {
                for (int j = 1; j < i + 1; j++)
                {
                    Console.Write($"{j}");
                }
                Console.WriteLine();
            }
        }

        public static void Question9()
        {
            int printNumber = 1;

            for (int i = 1; i < 6; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write($"{printNumber}");
                    printNumber++;
                }
                Console.WriteLine();
            }
        }
    }
}
