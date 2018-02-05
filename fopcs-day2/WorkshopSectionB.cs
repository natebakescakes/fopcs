using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fopcs_day2
{
    public class WorkshopSectionB
    {
        /* Write a program that takes a double precision number as input
         * and prints the square root of that number
         */
        public static double Question1(double number)
        {
            return Math.Sqrt(number);
        }

        // Same as Question 1 except result should be rounded to 3 numbers
        public static double Question2(double input)
        {
            return Math.Round(Math.Sqrt(input), 3);
        }

        /* Write a program that takes the salary as input and prints the total income as output
         *  where totalIncome = salary + (0.1 * salary) + (0.03 * salary)
         */
        public static string Question3(double salary)
        {
            double totalIncome = salary + (0.1 * salary) + (0.03 * salary);

            return $"{totalIncome:C}";
        }

        /* Write a program that would convert a given tempature as celcius to fahrenheit
         *  where F = 1.8C + 32
         */

        public static double Question4(double celsius)
        {
            double fahrenheit = (1.8 * celsius) + 32;

            return fahrenheit;
        }

        /* Write a program that would take as input the value of x and output the value of y
         *  where y = 5x^2 - 4x + 3
         */
        public static double Question5(double x)
        {
            double y = 5 * Math.Pow(x, 2) - 4 * x + 3;

            return y;
        }

        /* Write a program that reads the (x, y) coordinates of two points.
         * Compute the distance of the two points:
         *  where distance = sqrt((x2-x1)^2 + (y2-y1)^2)
         */
         public static double Question6(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            return distance;
        }

        /* Compute the total fare based on the kilometres travelled
         *  where totalFare = 2.4 + .4 * distance
         */
        public static double Question7(double distance)
        {
            double totalFare = 2.4 + 0.4 * distance;

            return totalFare;
        }

        /* Compute the same as above except rounded to the nearest 10 cents
         * and printing only the first 2 decimal places
         */
        public static string Question8(double distance)
        {
            double totalFare = 2.4 + 0.4 * distance;

            return $"{Math.Round(totalFare, 1):0.00}";
        }

        // Same as above except totalFare always rounded up to the nearest 10 cents
        public static double Question9(double distance)
        {
            double totalFare = 2.4 + 0.4 * distance;

            return Math.Round(totalFare + 0.05, 1);
        }

        /* Compute area of a triangle using the following formula:
         *  Area = Sqrt(s(s-a)(s-b)(s-c))
         *  where s = (a + b + c) / 2
         */
        public static double Question10(double a, double b, double c)
        {
            double s = (a + b + c) / 2;

            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            return area;
        }
    }
}
