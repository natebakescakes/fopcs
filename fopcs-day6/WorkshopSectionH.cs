using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fopcs_day6
{
    public class WorkshopSectionH
    {
        public delegate double DoubleOps(double x);

        public static void Question11()
        {
            double[] x = new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine(String.Join(", ", ProcessArray(x, (double i) => Math.Sqrt(i))));
            Console.WriteLine(String.Join(", ", ProcessArray(x, (double i) => Math.Pow(i, 2))));
        }

        public static double[] ProcessArray(double[] arr, DoubleOps ops)
        {
            double[] newArr = new double[arr.Length];

            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = ops(arr[i]);
            }

            return newArr;
        }
    }
}
