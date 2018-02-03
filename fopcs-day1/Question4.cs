using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * Write a program that takes a double precision number as input
 * and prints the square of that number
 */

namespace fopcs_day1
{
    class Question4
    {
        public static void question4()
        {
            Console.WriteLine("Please enter a double precision number: ");
            double number;

            while (true)
            {
                try
                {
                    number = Double.Parse(Console.ReadLine());
                    Console.WriteLine($"Your number squared is {Math.Pow(number, 2)}");
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
