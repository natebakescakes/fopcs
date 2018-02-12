using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalExercises
{
    public class PrintSeriesOfNumbers
    {
        public static void Question1()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.Write($"{i + 1} ");
            }
            Console.WriteLine();
        }

        public static void Question2()
        {
            for (int i = 20; i > 0; i--)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        public static void Question3a()
        {
            for (int i = 1; i < 21; i += 2)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        public static void Question3b()
        {
            for (int i = 1; i < 21; i++)
            {
                if (i % 2 != 0)
                    Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        public static int Fibonacci(int n)
        {
            if (n == 1)
                return 0;

            if (n == 2)
                return 1;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        public static void Question4()
        {
            for (int i = 1; i < 13; i++)
            {
                Console.Write($"{Fibonacci(i)} ");
            }
            Console.WriteLine();
        }

        public static void Question5()
        {
            for (int i = 1, j = 20; i < 11; i++, j--)
            {
                Console.Write($"{i} {j} ");
            }
            Console.WriteLine();
        }
    }
}
