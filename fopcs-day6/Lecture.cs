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

        #region Program2()
        public static void Program2()
        {
            int x = 3;
            int y = 4;

            Console.WriteLine(Multiply(x, y));

            Swap(ref x, ref y);
            Console.WriteLine($"{x}, {y}"); // 3, 4
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        #endregion

        #region Program3()
        public static void Program3()
        {
            int[] x = new int[] { 1, 2, 3, };
            Console.WriteLine($"{{ {String.Join(", ", x)} }}"); // { 1, 2, 3 }

            TimesTen(x);
            Console.WriteLine($"{{ {String.Join(", ", x)} }}"); // { 10, 20, 30 }

            DoubleTheSize(x); // pass by value (scoped method variable will copy the reference to X)
            Console.WriteLine(x.Length); // 3

            // pass by reference (scoped method variable will pass the reference of the reference to
            // the array in the heap)
            DoubleTheSize(ref x); 
            Console.WriteLine(x.Length); // 6

            x = DoubleTheSizeWithNoRef(x); // Assign the new address of the returned array to the x variablegh
            Console.WriteLine(x.Length); // 12

            // out keyword will pass by reference variables that are meant as output only
            // allows reference to uninitialized variable
            //
            // ref keyword requires variable passed into method to be initialised as it
            // assumes that you will need to use it as an input
        }

        private static int[] DoubleTheSizeWithNoRef(int[] A)
        {
            int[] B = new int[A.Length * 2];

            for (int i = 0; i < A.Length; i++)
            {
                B[i] = A[i];
            }

            return B;
        }

        public static void DoubleTheSize(ref int[] A)
        {
            int[] B = new int[A.Length * 2];

            for (int i = 0; i < A.Length; i++)
            {
                B[i] = A[i];
            }

            A = B;
        }

        public static void DoubleTheSize(int[] A)
        {
            int[] B = new int[A.Length * 2];

            for (int i = 0; i < A.Length; i++)
            {
                B[i] = A[i];
            }

            A = B; // modifying the address of A which does not affect the address of outside the method.
            // If you which to modify the outside address, use ref keyword
        }
        
        public static void TimesTen(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = A[i] * 10;
            }
        }
        #endregion
    }
}
