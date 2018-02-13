using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalExercises
{
    public class SingleDimensionArray
    {
        public int[] intArray = new int[]
        {
            1, 5, 3, 326, 23, 7, 34, 1, 2, 4, 7
        };

        public static int IndexSearch(int num, int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    return i;
                }
            }

            return -1;
        }

        public static int[] SortArray(int[] arr)
        {
            int[] newArr = new int[arr.Length];
            arr.CopyTo(newArr, 0);

            for (int i = 0; i < newArr.Length - 1; i++)
            {
                for (int j = i+1; j < newArr.Length; j++)
                {
                    if (newArr[i] < newArr[j])
                    {
                        int temp = newArr[i];
                        newArr[i] = newArr[j];
                        newArr[j] = temp;
                    }
                }
            }

            return newArr;
        }

        public static int BinarySearch(int num, int[] arr)
        {
            int[] newArr = SortArray(arr);
            bool unableToFind = false;
            int index = newArr.Length / 2;

            do
            {
                if (newArr[index] == num)
                    return index;

                if (newArr[index] < num)
                {
                    index = (index + newArr.Length) / 2;
                }
                else
                {
                    index /= 2;
                }
            } while (!unableToFind);

            return index;
        }
    }
}
