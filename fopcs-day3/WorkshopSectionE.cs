using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fopcs_day3
{
    public class WorkshopSectionE
    {
        // factorial of input using incrementor
        public static int Question1a(int input)
        {
            int result = 1;

            for (int i = 0; i < input; i++)
            {
                result = result * (i + 1);
            }

            return result;
        }

        // factorial of input using decrementor
        public static int Question1b(int input)
        {
            int result = 1;

            for (int i = input; i > 0; i--)
            {
                result = result * i;
            }

            return result;
        }

        public static void Question2()
        {
            for (int i = 0; i < 12; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("NO\tINVERSE\tSQUARE ROOT\tSQUARE");
                }
                else if (i == 1)
                {
                    for (int j = 0; j < 45; j++)
                    {
                        Console.Write("-");
                    }

                    Console.WriteLine();
                }
                else
                {
                    double no = i - 1;
                    double inverse = 1 / (no);
                    double sqrt = Math.Sqrt(no);
                    double square = Math.Pow(no, 2);

                    Console.WriteLine($"{no:0.0}\t{inverse:0.###}\t{sqrt:#.###}\t{square:0.0}");
                }
            }
        }

        public static string Question3(int input)
        {
            for (int i = 0; i < input - 2; i++)
            {
                if (input % (i + 2) == 0)
                {
                    return "Not Prime";
                }
            }

            return "Prime";
        }

        public static bool Question4(int input)
        {
            int test = 0;

            for (int i = 1; i < input; i++)
            {
                if (input % i == 0)
                {
                    test += i;
                }
            }

            return input == test;
        }

        public static void Question5()
        {
            for (int i = 5; i < 10001; i++)
            {
                if (Question3(i) == "Prime")
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void Question6()
        {
            for (int i = 1; i < 1001; i++)
            {
                if (Question4(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
