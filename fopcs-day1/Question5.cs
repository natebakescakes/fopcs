using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program that takes a double precision number
 * and inputs and prints the number with 2 decimal points as its output
 */

namespace fopcs_day1
{
    class Question5
    {
        public static void question5()
        {
            Console.WriteLine("Please input a number: ");
            double number;

            while (true)
            {
                try
                {
                    number = Double.Parse(Console.ReadLine());
                    Console.WriteLine($"Your number is {number:.00}");
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Your input was not a number, please try again: ");
                }
            }
        }
    }
}
