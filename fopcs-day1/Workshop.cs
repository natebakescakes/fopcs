using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace fopcs_day1
{
    class Workshop
    {

        /*
         * Write a program that will print out your detail in the following format:
         * Line 1: Name
         * Line 2: Email
         */
        public static void Question1()
        { 
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your email: ");
            string email = Console.ReadLine();

            Console.WriteLine($"{name}");
            Console.WriteLine($"{email}");
        }

        /*
         * Write a program that would request for your name and print a greeting like 
         * this:
         *          Good Morning John
         * where John is the name you had input.
         */
        public static void Question2()
        {
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Good Morning {name}");
        }

        /* 
         * Write a program that takes an integer as input and prints the square of 
         * that number.
         */
        public static void Question3()
        {
            Console.WriteLine("Please enter a number: ");
            int number;

            while (true)
            {
                try
                {
                    number = Int32.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("The number entered is not an integer, please try again: ");
                    continue;
                }

                Console.WriteLine($"Your number squared is {Math.Pow(number, 2)}");
            }
        }

        /*
         * Write a program that takes a double precision number as input and prints 
         * the number with 2 decimal points in the output.
         */
        public static void Question4()
        {
            Console.WriteLine("Please enter a double precision number: ");
            double number;

            while (true)
            {
                try
                {
                    number = Double.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Your input was not a number, please try again: ");
                    continue;
                }

                Console.WriteLine($"Your number squared is {Math.Pow(number, 2)}");

            }
        }

        /*
         * Write a program that takes a double precision number as input and prints
         * the number with 2 decimal points in the output.
         */
        public static void Question5()
        {
            Console.WriteLine("Please input a number: ");
            double number;

            while (true)
            {
                try
                {
                    number = Double.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Your input was not a number, please try again: ");
                    continue;
                }

                Console.WriteLine($"Your number is {number:.00}");

            }
        }
    }
}
