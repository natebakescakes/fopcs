using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fopcs_day4
{
    public class WorkshopSectionF
    {
        /* Modify Program 2 to accomodate sentences which may have upper case letters,
         * punctuations or space that may need to be ignored during the test.
         */
        public static void Question3()
        {
            Console.Write("Please input your phrase: ");

            if (Palindrome(Console.ReadLine()))
            {
                Console.WriteLine("It's a Palindrome!");
            }
            else
            {
                Console.WriteLine("It's not a Palindrome. :(");
            }
        }

        public static bool Palindrome(string s)
        {
            bool palCheck = false;

            StringBuilder sb = new StringBuilder();

            foreach (char sChar in s.ToUpper())
            {
                if ("ABCDEFGHIJKLMNOPQRSTUVWXYZ".Contains(sChar))
                {
                    sb.Append(sChar);
                }
            }

            string removedSpecialChar = sb.ToString();

            for (int i = 0; i < removedSpecialChar.Length / 2; i++)
            {
                if (removedSpecialChar[i] == removedSpecialChar[(removedSpecialChar.Length - 1) - i])
                {
                    palCheck = true;
                }
                else
                {
                    break;
                }
            }

            return palCheck;
        }

        // Write a program that would convert a string of words to capitalised
        public static string Question4(string s)
        {
            string[] words = s.Split(' ');

            string[] result = new string[words.Length];

            for (int wordIndex = 0; wordIndex < words.Length; wordIndex++)
            {
                StringBuilder sb = new StringBuilder();

                for (int letterIndex = 0; letterIndex < words[wordIndex].Length; letterIndex++)
                {
                    if (letterIndex == 0)
                    {
                        sb.Append(words[wordIndex][letterIndex].ToString().ToUpper());
                    }
                    else
                    {
                        sb.Append(words[wordIndex][letterIndex].ToString());
                    }
                }

                result[wordIndex] = sb.ToString();
            }

            return String.Join(" ", result);
        }

        // Implement a sorting algorithm for int
        public static void Question5a()
        {
            int[] marks = new int[] { 63, 29, 75, 82, 55 };

            for (int i = 0; i < marks.Length - 1; i++)
            {
                for (int j = i+1; j < marks.Length; j++)
                {
                    if (marks[j] > marks[i]) // descending order
                    {
                        int temp = marks[i];
                        marks[i] = marks[j];
                        marks[j] = temp;
                    }
                }
            }

            Console.WriteLine(String.Join(" ", marks));
        }

        // Implement a sorting algorithm for string
        public static void Question5b()
        {
            string[] names = new string[] { "John", "Venkat", "Mary", "Victor", "Betty" };

            for (int i = 0; i < names.Length - 1; i++)
            {
                for (int j = i+1; j < names.Length; j++)
                {
                    if (names[i].CompareTo(names[j]) == 1) // if names[i] follows names[j]
                    {
                        string temp = names[i];
                        names[i] = names[j];
                        names[j] = temp;
                    }
                }
            }

            Console.WriteLine(String.Join(" ", names));
        }

        public static void Question6()
        {
            Console.Write("Enter a matriculation number: ");
            string input = Console.ReadLine();

            Console.WriteLine(CheckSum(input) ? "Valid" : "Invalid");
        }

        public static bool CheckSum(string matNumber)
        {
            if (matNumber.Length != 7)
                return false;

            string numbers = matNumber.ToString().Substring(1, 5);
            string checkSum;
            int total = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int no;
                Int32.TryParse(numbers[i].ToString(), out no);
                total += no;
            }

            switch (total % 5)
            {
                case 0:
                    checkSum = "O";
                    break;
                case 1:
                    checkSum = "P";
                    break;
                case 2:
                    checkSum = "Q";
                    break;
                case 3:
                    checkSum = "R";
                    break;
                case 4:
                    checkSum = "S";
                    break;
                default:
                    checkSum = "AA";
                    break;
            }

            if (checkSum == matNumber.ToUpper().Substring(6, 1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
