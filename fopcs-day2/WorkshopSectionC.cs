using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fopcs_day2
{
    public class WorkshopSectionC
    {
        public static string Question1(string name, string gender)
        {
            string salutation = gender == "M" ? "Mr." : "Ms.";

            return $"Good Morning {salutation} {name}";
        }

        public static string Question2(string name, string gender, double age)
        {
            string salutationYoung = gender == "M" ? "Mr." : "Ms.";
            string salutationOld = gender == "M" ? "Uncle" : "Aunty";

            string salutation = age >= 40 ? salutationOld : salutationYoung;

            return $"Good Morning {salutation} {name}";
        }

        public static string Question3 (int score)
        {
            if ((score >= 80) && (score <= 100))
            {
                return "A";
            }
            else if ((score >= 60) && (score < 80))
            {
                return "B";
            }
            else if ((score >= 40) && (score < 60))
            {
                return "C";
            }
            else if (score >= 0 && (score <= 40))
            {
                return "F";
            }
            else
            {
                return "**Error**";
            }
        }

        public static double Question4 (double distance)
        {
            distance = Math.Ceiling(distance * 10);

            double totalFare = 0;

            if (distance >= 0)
            {
                totalFare += 2.4;
            }
            if (distance > 5)
            {
                totalFare += Math.Min(85, distance - 5) * 0.04;
            }
            if (distance > 90)
            {
                totalFare += (distance - 90) * 0.05;
            }

            return totalFare;
        }

        public static bool Question5 (int number)
        {
            int hundreds, tens, ones;

            hundreds = number / 100;
            tens = (number % 100) / 10;
            ones = number - hundreds * 100 - tens * 10;

            int check = (int) (Math.Pow(hundreds, 3) + Math.Pow(tens, 3) + Math.Pow(ones, 4));

            return number == check;
        }

        public static bool Question5a (string number)
        {
            double temp = Double.Parse(number); // Iterable
            double lengthOfString = number.Length; // Variable length of string
            double check = 0;

            while (temp != 0)
            {
                int leftmost = (int) (temp / Math.Pow(10, lengthOfString - 1));

                check += Math.Pow(leftmost, number.Length);
                temp -= leftmost * Math.Pow(10, lengthOfString - 1);
                lengthOfString--;
            }

            return check == Double.Parse(number);
        }
    }
}
