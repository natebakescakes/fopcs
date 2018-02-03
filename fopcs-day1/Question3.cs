using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program that takes an integer of that input and prints the square of that number
 */

namespace fopcs_day1
{
    class Question3
    {
        public static void question3()
        {
            Console.WriteLine("Please enter a number: ");
            int number;

            while (true)
            {
                try
                {
                    number = Int32.Parse(Console.ReadLine());
                    Console.WriteLine($"Your number squared is {Math.Pow(number, 2)}");
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("The number entered is not an integer, please try again: ");
                }
            }
        }
    }
}
