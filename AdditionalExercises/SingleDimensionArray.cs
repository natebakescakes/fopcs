using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalExercises
{
    public class SingleDimensionArray
    {
        //Question 15
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

        //Question 16
        public static int[] SortArray(int[] arr)
        {
            int[] newArr = new int[arr.Length];
            arr.CopyTo(newArr, 0);

            for (int i = 0; i < newArr.Length - 1; i++)
            {
                for (int j = i+1; j < newArr.Length; j++)
                {
                    if (newArr[i] > newArr[j])
                    {
                        int temp = newArr[i];
                        newArr[i] = newArr[j];
                        newArr[j] = temp;
                    }
                }
            }

            return newArr;
        }

        //Question 17
        public static int BinarySearch(int num, int[] arr)
        {
            int[] newArr = SortArray(arr);

            int upperBound = arr.Length;
            int lowerBound = 0;

            do
            {
                int index = (lowerBound + upperBound) / 2;

                if (newArr[index] == num)
                    return index;

                if (newArr[index] > num)
                {
                    lowerBound = index;
                }
                else
                {
                    upperBound = index;
                }
            } while (upperBound != lowerBound);

            return -1;
        }
    }
}
