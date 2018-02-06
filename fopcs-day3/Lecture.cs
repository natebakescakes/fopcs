using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fopcs_day3
{
    public class Lecture
    {
        public static void Program1()
        {
            // Counting i starting from 0, each time incrementing i by 1, while i < 10
            // i to go from 0 to 9
            //for (int i = 0; i < 10; i++) // Initialization; Condition; Increment/Decrement
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 10; i < 16; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int j = 20; j > 9; j--)
            //{
            //    Console.WriteLine(j);
            //}

            for (int i = 0; i < 11; i += 2)
            {
                Console.WriteLine(i);
            }
        }

        public static void Program2()
        {
            // a program that asks for password
            // the password is ISS
            // if the person give wrong password 3 times,
            // the system will be locked

            //Repeat 3 Times
            //  Ask for password
            //  If password correct
            //      say Congrats and exit
            //  else
            //      say Password Incorrect

            for (int i = 0; i < 3; i++)
            {
                // Ask for password
                Console.Write("Enter password: ");
                string input = Console.ReadLine();

                // If password correct
                if (input == "ISS")
                {
                    // Say congrats!
                    Console.WriteLine("Congratulations!");

                    // Exit the loop
                    break;
                }
                else
                {
                    // Say password incorrect
                    Console.WriteLine("Password Incorrect!");

                    if (i == 2)
                    {
                        Console.WriteLine("Game Over");
                    }
                }
            }
        }

        public static void Program3()
        {
            for (int i = 0; i < 7; i++)
            {
                // if you want to print the first line
                // i must start from 1, therefore j < 1 for the first iteration
                for (int j = 0; j < i+1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static void Program4()
        {
            // pick a number 1-9
            Random r = new Random();
            int secretNumber = r.Next(1, 10);
            bool correctGuess = false;

            while (!correctGuess)
            {
                Console.WriteLine("Please enter a guess: ");
                int guess = Int32.Parse(Console.ReadLine());
                if (guess == secretNumber)
                {
                    Console.WriteLine("Congratulation! You have guessed the number!");
                    correctGuess = true;
                }
                else
                {
                    Console.WriteLine("Wrong guess! :(");
                }
            } 
        }

        public static void Program5()
        {
            // Ask user for length in cm
            // convert to inch, where inches = length in cm / 2.54
            // print out the answer

            double length;
            bool successfulParse;

            do
            {
                Console.Write("Please enter the length in cm: ");
                successfulParse = Double.TryParse(Console.ReadLine(), out length);

                if (length < 0)
                {
                    Console.WriteLine("You have entered a negative number!");
                }

            } while (length < 0 || !successfulParse);

            Console.WriteLine($"{length / 2.54}");
        }

        public static void Program6()
        {

        }
    }
}
