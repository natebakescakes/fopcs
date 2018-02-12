using System;

namespace AdditionalExercises
{
    public class MultiDimensionArray
    {
        //Question 18
        public static double[] AverageArray(int[,] arr)
        {
            double[] averageArray = new double[arr.GetLength(0)];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                double total = 0;

                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    total += arr[i, j];
                }

                averageArray[i] = total / arr.GetLength(1);
            }
            return averageArray;
        }

        //Question 19
        public static int[] MaxArray(int[,] arr)
        {
            int[] maxArray = new int[arr.GetLength(0)];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int maxValue = arr[i, 0];

                for (int j = 1; j < arr.GetLength(1); j++)
                {
                    maxValue = Math.Max(maxValue, arr[i, j]);
                }

                maxArray[i] = maxValue;
            }

            return maxArray;
        }

        public static double[,] AverageTwoDimension(int[,,] arr)
        {
            double[,] averageArray = new double[arr.GetLength(0), arr.GetLength(1)];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    double total = 0;

                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        total += arr[i, j, k];
                    }

                    averageArray[i, j] = total / arr.GetLength(1);
                }
            }

            return averageArray;
        }
    }
}
