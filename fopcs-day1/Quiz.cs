using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a program to convert length measurement from centimetre to inch
 * The measurement in inch can be calculated using the following formula:
 *  Length in inch = Length in cm / 2.54
 *  Format the result with three digits behind the decimal points
 *  (refer to the sample output as reference)
 */
 
namespace fopcs_day1
{
    public class Quiz
    {
        public static void Question()
        {
            double number;

            while (true)
            {
                Console.WriteLine("Please enter the length in cm: ");

                try
                {
                    number = Double.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("You did not enter a number, please try again! ");
                    continue;
                }
            }

            Console.WriteLine($"This is your number: {(number / 2.54):0.000}");

        }
    }
}
