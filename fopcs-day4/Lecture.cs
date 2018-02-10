using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fopcs_day4
{
    class Lecture
    {
        public static void Program1()
        {
            int[] A = new int[4];
            A[0] = 100;
            A[1] = 200;
            A[2] = 300;

            int i = 1;
            A[i] = 1000; // A[1] = 1000

            //i = 10;
            //A[i] = 1000; // Gives exception A[10] = 1000;

            int[] B = new int[3] { 1, 2, 3 };

            int[,] C = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } }; // multi-dimensional
            int[,,] D = new int[3,3,3];

            for (int j = 0; j < D.GetLength(0); j++)
            {
                for (int k = 0; k < D.GetLength(1); k++)
                {
                    for (int l = 0; l < D.GetLength(2); l++)
                    {
                        Console.WriteLine(D[j,k,l]);
                    }
                }
            }

            Console.WriteLine(D.Rank); // No. of dimensions
        }

        public static void Program2()
        {
            // Rudimentary sorting algorithm
            int[] A = { 100, 98, 86, 23, 34, 56, 78, 91, 21, 3, 5 };

            for (int green = 0; green < A.Length-1; green++)
            {
                for (int red = green+1; red < A.Length; red++)
                {
                    if (A[red] < A[green])
                    {
                        // swap
                        int temp = A[red];
                        A[red] = A[green];
                        A[green] = temp;
                    }
                }
            }

            Console.WriteLine(String.Join(", ", A));
        }

        public static void Program3()
        {
            // declare a 3-dimensional array
            int[,,] intArray = new int[,,]
            {
                {
                    { 1, 2 },
                    { 3, 4 },
                    { 2, 4 }
                },
                {
                    { 2, 3 },
                    { 3, 4 },
                    { 3, 5 }
                },
                {
                    { 2, 3 },
                    { 3, 4 },
                    { 3, 5 }
                },
                {
                    { 2, 3 },
                    { 3, 4 },
                    { 3, 5 }
                }
            };
        }
    }
}
