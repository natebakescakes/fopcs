using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fopcs_day6
{
    public class Lecture
    {
        #region Program1()
        public static void Program1()
        {
            int[] A = new[] { 1, 2, 3 };

            int[] B = SquareArray(A);
            PrintArray(B); // { 1, 4, 9 }

            int[] C = IncrementArray(A);
            PrintArray(C); // { 2, 3, 4 }

            int[] D = ApplyOperation(A, Square); // To apply Square operations to elements in array
            PrintArray(D); // { 1, 4, 9 }
            int[] E = ApplyOperation(A, TimesTen); // To apply TimesTen operation to elements in array
            PrintArray(E); // { 10, 20, 30 }

            IntOps times100 = delegate (int x) { return x * 100; }; // Anonymous Methods = do not belong to a class
            int[] F = ApplyOperation(A, times100);
            PrintArray(F); // { 100, 200, 300 }

            // You can define anonymous methods long as it complies with delegate input and output
            IntOps times100b = delegate (int x) { return TimesN(x, 100); }; 
            int[] G = ApplyOperation(A, times100b);
            PrintArray(G); // { 100, 200, 300 }

            // Pass method directly into method that takes in a delegate;
            int[] H = ApplyOperation(A, delegate (int x) { return x * 100; });
            PrintArray(H); // { 100, 200, 300 }

            // Lambda expressions - writing anonymous functions
            int[] I = ApplyOperation(A, (int x) => { return x * 100; });
            PrintArray(I); // { 100, 200, 300 }

            int[] J = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            List<int> K = new List<int>(
                from x in J
                where x % 2 == 0
                select x);
            PrintArray(K); // { 2, 4, 6, 8 }

        }

        private static int Square(int x) { return x * x; }
        private static int Increment(int x) { return x + 1; }
        private static int TimesTen(int x) { return x * 10; }
        private static int TimesN(int x, int n) { return x * n; }
        private static double Sqrt(double x) { return Math.Sqrt(x); } // Not acceptable by IntOps delegate
        private static int Sqrt(int x) { return (int)Math.Sqrt(x); } // Acceptable overload by IntOps

        delegate int IntOps(int b); // Operation that takes an integer and outputs an integer

        private static int[] ApplyOperation(int[] A, IntOps ops)
        {
            int[] newArray = new int[A.Length];

            for (int i = 0; i < A.Length; i++)
            {
                newArray[i] = ops(A[i]); // Applying ops to each element
            }

            return newArray;
        }

        // This method will perform square operation for each element of the array
        private static int[] SquareArray(int[] A)
        {
            int[] newArray = new int[A.Length];

            for (int i = 0; i < A.Length; i++)
            {
                newArray[i] = (int)Math.Pow(A[i], 2);
            }

            return newArray;
        }

        // This method will add each element of the array with 1
        private static int[] IncrementArray(int[] A)
        {
            int[] newArray = new int[A.Length];

            for (int i = 0; i < A.Length; i++)
            {
                newArray[i] = A[i] + 1;
            }

            return newArray;
        }

        private static void PrintArray(int[] A)
        {
            Console.WriteLine($"[ {String.Join(", ", A)} ]");
        }

        private static void PrintArray(List<int> A)
        {
            Console.WriteLine($"[ {String.Join(", ", A)} ]");
        }
        #endregion
    }
}
