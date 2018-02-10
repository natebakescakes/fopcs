using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fopcs_day5
{
    public class WorkshopSectionH
    {
        public static int ReadInteger(string s)
        {
            bool acceptedString = false;
            int input;

            do
            {
                Console.Write(s);
                acceptedString = Int32.TryParse(Console.ReadLine(), out input);

            } while (!acceptedString);

            return input;
        }

        public static void PrintArray(int[] arr)
        {
            Console.WriteLine(String.Join(", ", arr));
        }

        public static bool InString(string s1, string s2)
        {
            bool found = false;

            for (int i = 0; i < s1.Length-(s2.Length-1); i++)
            {
                if (s1.ToUpper().Substring(i, s2.Length) == s2.ToUpper())
                {
                    found = true;
                }
            }

            return found;
        }

        public static int FindWord(string s1, string s2)
        {
            int index = -1;

            for (int i = 0; i < s1.Length - (s2.Length - 1); i++)
            {
                if (s1.ToUpper().Substring(i, s2.Length) == s2.ToUpper())
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        public static string Hexadecimal(int input)
        {
            if (input == 0)
                return "0";
            
            StringBuilder sb = new StringBuilder();
            int temp = input;
            string hexaTable = "0123456789ABCDEF";
            

            while (temp != 0)
            {
                sb.Insert(0, hexaTable[temp % 16]);

                temp /= 16;
            }

            return sb.ToString();
        }

        public static string Substitute(string s, char c1, char c2)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c1)
                {
                    sb.Append(c2);
                }
                else
                {
                    sb.Append(s[i]);
                }
            }

            return sb.ToString();
        }

        public static int[] ResizeArray(int[] arr, int newSize)
        {
            int[] newArray = new int[newSize];
            Array.Copy(arr, newArray, Math.Min(arr.Length, newArray.Length));

            return newArray;
        }

        public static bool IsPrime(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static void PrintPrime()
        {
            for (int i = 5; i < 1001; i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static int[,] MatrixMultiply(int[,] A, int[,] B)
        {
            if (A.GetLength(1) != B.GetLength(0))
            {
                throw new ArgumentException(
                    "Unable to proceed with matrix multiplication as no. of columns of A" +
                    "and no. of rows of B are not equal"
                    );
            }

            int commonLength = A.GetLength(1);
            int[,] result = new int[A.GetLength(0), B.GetLength(1)];         

            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    int value = 0;

                    for (int k = 0; k < commonLength; k++)
                    {
                        value += (A[i, k] * B[k, j]);
                    }

                    result[i, j] = value;
                }
            }

            return result;
        } 
    }
}
