using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdditionalExercises
{
    public class Methods
    {
        public enum TriangleType
        {
            LeftAligned,
            Center,
            RightAligned,
            InvertedLeftAligned,
            InvertedCenter,
            InvertedRightAligned
        }

        //Question 21
        public static void PrintTriangle(TriangleType triangleType, int height)
        {
            switch (triangleType)
            {
                case TriangleType.LeftAligned:
                    LeftAligned(height);
                    break;
                case TriangleType.Center:
                    Center(height);
                    break;
                case TriangleType.RightAligned:
                    RightAligned(height);
                    break;
                case TriangleType.InvertedLeftAligned:
                    InvertedLeftAligned(height);
                    break;
                case TriangleType.InvertedCenter:
                    InvertedCenter(height);
                    break;
                case TriangleType.InvertedRightAligned:
                    InvertedRightAligned(height);
                    break;
            }

        }

        private static void LeftAligned(int height)
        {
            string s = "";

            for (int i = 0; i < height; i++)
            {
                s += "*";
                Console.WriteLine(s);
            }
        }

        private static void RightAligned(int height)
        {
            string s = "";

            for (int i = 0; i < height; i++)
            {
                s += "*";
                string format = "{0," + height + "}";
                Console.WriteLine(format, s);
            }
        }

        private static void Center(int height)
        {
            string stars = "";

            for (int i = 0, j = height; i < height; i++, j -= (i % 2 == 0 ? 1 : 0))
            {
                stars += "*";
                String spaces = new String(' ', j);
                Console.WriteLine($"{spaces}{stars}");
            }
        }

        private static void InvertedLeftAligned(int height)
        {
            string s = new String('*', height);

            for (int i = 0; i < height; i++)
            {
                s = s.Substring(0, height - i);
                Console.WriteLine(s);
            }
        }

        private static void InvertedCenter(int height)
        {
            for (int i = height, j = height; i >= 0; i--, j += (i % 2 == 0 ? 1 : 0))
            {
                String stars = new string('*', i);
                String spaces = new string(' ', j);
                Console.WriteLine($"{spaces}{stars}");
            }
        }

        private static void InvertedRightAligned(int height)
        {
            string s = new String('*', height);

            for (int i = 0; i < height; i++)
            {
                s = s.Substring(0, height - i);
                string format = "{0," + height + "}"; // {0, 10}
                Console.WriteLine(format, s);
            }
        }

        //Question 22
        public static int[] ResizeArray(int[] arr, int newLength)
        {
            int[] newArr = new int[newLength];

            for (int i = 0; i < Math.Min(newLength, arr.Length); i++)
            {
                newArr[i] = arr[i];
            }

            return newArr;
        }

        public static void Swap(ref int a, ref int b)
        {
            int tempA = a, tempB = b;
            b = Math.Max(tempA, tempB);
            a = Math.Min(tempA, tempB);
        }

        public delegate bool ValidationCheck(string s);

        public static void InputValidation(string s, ValidationCheck ops)
        {
            do
            {
                Console.Write("Please enter an input: ");
            } while (!ops(s));
        }

        // Used non-static Array.Contains method
        public static bool PasswordCheck(string s)
        {
            string lower = "abcdefghijklmnopqrstuvwxyz";
            string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string number = "0123456789";

            bool lowerCheck = false;
            bool upperCheck = false;
            bool numberCheck = false;

            for (int i = 0; i < s.Length; i++)
            {
                if (lower.Contains(s[i]))
                {
                    lowerCheck = true;
                    break;
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (upper.Contains(s[i]))
                {
                    upperCheck = true;
                    break;
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (number.Contains(s[i]))
                {
                    numberCheck = true;
                    break;
                }
            }

            if (lowerCheck && upperCheck && numberCheck && s.Length >= 7)
                return true;
            else
                return false;
        }

        // Used non-static Array.Contains method
        public static bool FormatCheck(string s)
        {
            if (s.Length != 7)
                return false;

            string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string number = "0123456789";

            for (int i = 0; i < 2; i++)
            {
                if (!upper.Contains(s.ToUpper()[i]))
                    return false;
            }

            for (int i = 2; i < s.Length; i++)
            {
                if (!number.Contains(s[i]))
                    return false;
            }

            return true;
        }

        // I gave up and used Regex
        public static bool EmailCheck(string s)
        {
            return Regex.IsMatch(s, @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-]+$");
        }
    }
}
