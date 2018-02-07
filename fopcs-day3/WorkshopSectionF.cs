using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fopcs_day3
{
    public class WorkshopSectionF
    {
        public static void Question1a()
        {
            Console.WriteLine("Please enter your phrase: ");
            string s = Console.ReadLine();
            string vowels = "AEIOU";
            int vowelCount = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (vowels.Contains(s.ToUpper()[i]))
                {
                    vowelCount++;
                }
            }

            Console.WriteLine($"Your phrase contains {vowelCount} vowels!");
        }

        public static void Question1b()
        {
            Console.WriteLine("Please enter your phrase: ");
            string s = Console.ReadLine();
            int aCount = 0, eCount = 0, iCount = 0, oCount = 0, uCount = 0;

            for (int i = 0; i < s.Length; i++)
            {
                switch (s.ToUpper()[i])
                {
                    case 'A':
                        aCount++;
                        break;
                    case 'E':
                        eCount++;
                        break;
                    case 'I':
                        iCount++;
                        break;
                    case 'O':
                        oCount++;
                        break;
                    case 'U':
                        uCount++;
                        break;
                }
            }

            Console.WriteLine($"A: {aCount}");
            Console.WriteLine($"E: {eCount}");
            Console.WriteLine($"I: {iCount}");
            Console.WriteLine($"O: {oCount}");
            Console.WriteLine($"U: {uCount}");
        }

        public static void Question2()
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

            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s.ToUpper()[i] == s.ToUpper()[(s.Length -1) - i])
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
    }
}
