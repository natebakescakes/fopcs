using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fopcs_day4
{
    public class WorkshopSectionG
    {
        public static void Question1()
        {
            double[] sales = new double[12]
            {
                1300.00, // Janaury
                1142.00, // February
                1324.00, // March
                1234.00, // April
                4932.00, // May
                3453.00, // June
                1235.00, // July
                4852.00, // August
                4860.00, // September
                2345.00, // October
                3456.00, // November
                4567.00 // December
            };

            Console.WriteLine($"Month of Maximum Sales: {MaxSales(sales)}");
            Console.WriteLine($"Month of Minimum Sales: {MinSales(sales)}");
            Console.WriteLine($"Average Sales: {AverageSales(sales)}");
        }

        public static double AverageSales(double[] sales)
        {
            double total = 0;

            for (int i = 0; i < sales.Length; i++)
            {
                total += sales[i];
            }

            return total / sales.Length;
        }

        public static int MaxSales(double[] sales)
        {
            double maxSales = -1;

            for (int i = 0; i < sales.Length; i++)
            {
                if (sales[i] > maxSales)
                {
                    maxSales = sales[i];
                }
            }

            for (int j = 0; j < sales.Length; j++)
            {
                if (sales[j] == maxSales)
                {
                    return j;
                }
            }

            return -1;
        }

        public static int MinSales(double[] sales)
        {
            double minSales = Double.MaxValue;

            for (int i = 0; i < sales.Length; i++)
            {
                if (sales[i] < minSales)
                {
                    minSales = sales[i];
                }
            }

            for (int j = 0; j < sales.Length; j++)
            {
                if (sales[j] == minSales)
                {
                    return j;
                }
            }

            return -1;
        }

        public static void Question2()
        {
            int[] array = new int[] { 234, 21, 361, 43, 456, 7, 55, 34, 865, 64 };

            for (int i = 0; i < array.Length-1; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;

                        Console.WriteLine($"Swapped position {i} with {j}");
                    }
                }
            }

            Console.WriteLine(String.Join(", ", array));
        }

        public static void Question3()
        {
            int[,] marks = new int[,]
            {
                { 56, 84, 68, 29 },
                { 94, 73, 31, 96 },
                { 41, 63, 36, 90 },
                { 99, 9, 18, 17 },
                { 62, 3, 65, 75 },
                { 40, 96, 53, 23 },
                { 81, 15, 27, 30 },
                { 21, 70, 100, 22 },
                { 88, 50, 13, 12 },
                { 48, 54, 52, 78 },
                { 64, 71, 67, 25 },
                { 16, 93, 46, 72 }
            };

            Console.WriteLine(String.Join(", ", TotalMarksPerStudent(marks)));
            Console.WriteLine(String.Join(", ", AverageMarks(marks)));
            Console.WriteLine(String.Join(", ", stdDevMarks(marks)));

        }

        public static int[] TotalMarksPerStudent(int[,] marks)
        {
            int[] total = new int[marks.GetLength(0)];

            for (int i = 0; i < marks.GetLength(0); i++)
            {
                int sumMarks = 0;

                for (int j = 0; j < marks.GetLength(1); j++)
                {
                    sumMarks += marks[i, j];
                }

                total[i] = sumMarks;
            }

            return total;
        }

        public static double[] AverageMarks(int[,] marks)
        {
            double[] average = new double[marks.GetLength(1)];

            for (int i = 0; i < marks.GetLength(1); i++)
            {
                double sumMarks = 0;

                for (int j = 0; j < marks.GetLength(0); j++)
                {
                    sumMarks += marks[j, i];
                }

                average[i] = sumMarks / marks.GetLength(0);
            }

            return average;
        }

        public static double[] stdDevMarks(int[,] marks)
        {
            double[] stddev = new double[marks.GetLength(1)];

            for (int i = 0; i < marks.GetLength(1); i++)
            {
                double sumMarksXMinusM = 0;

                for (int j = 0; j < marks.GetLength(0); j++)
                {
                    sumMarksXMinusM += (marks[j, i] - AverageMarks(marks)[i]);
                }

                Console.WriteLine(sumMarksXMinusM);
                //stddev[i] = Math.Sqrt(Math.Pow(sumMarksXMinusM, 2) / marks.GetLength(0));
            }

            return stddev;
        }

        public static void Question4()
        {
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }

            Console.WriteLine($"[ {String.Join(", ", array)} ]");
        }

        public static void Question5()
        {
            Console.Write("Enter a number: ");
            int input = Int32.Parse(Console.ReadLine());

            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }

            int index = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (input == array[i])
                {
                    index = i + 1;
                }
            }

            Console.WriteLine($"Number {input} is found in the array at element no. {index}");
        }

        public static void Question6()
        {
            int[] array = new int[] { 4, 5, 2, 3, 6, 8, 34, 8, 5, 2, 35, 6, 7, 9 };

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j]) // if ascending, operator should be '>' else '<'
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            Console.WriteLine(String.Join(", ", array));
        }

        public static void Question7()
        {
            string[] names = new string[] 
            {
                "Bob", "Charlie", "Dennis", "Eli", "Frank", "Gina", "Alice"
            };

            int[] scores = new int[]
            {
                90, 120, 80, 76, 66, 88, 100
            };

            for (int i = 0; i < names.Length - 1; i++)
            {
                for (int j = i + 1; j < names.Length; j++)
                {
                    if (names[i].CompareTo(names[j]) == 1) // if names[i] follows names[j]
                    {
                        string tempName = names[i];
                        int tempScore = scores[i];

                        names[i] = names[j];
                        scores[i] = scores[j];

                        names[j] = tempName;
                        scores[j] = tempScore;
                    }
                }
            }

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{names[i]}\t{scores[i]}");
            }
        }

        public static void Question8()
        {
            Console.Write("Enter a number: ");
            int input = Int32.Parse(Console.ReadLine());

            int[,] numbers = new int[,]
            {
                { 2, 4 },
                { 6, 8 },
                { 3, 5 },
                { 7, 9 }
            };

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    if (input == numbers[i, j])
                    {
                        Console.WriteLine($"Number {input} is found in the array at [{i}, {j}].");
                    }
                }
            }
        }
    }
}
