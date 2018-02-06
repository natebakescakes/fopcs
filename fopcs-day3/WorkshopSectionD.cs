using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fopcs_day3
{
    public class WorkshopSectionD
    {
        /* Write a C# program that would keep prompting you to enter an integer
         * number over and over again until you enter the number 88.
         * If you enter 88, the program should print "Lucky you..." and exit
         */
        public static void Question1()
        {
            bool correctNumber = false;
            bool correctInput;
            int input;

            while (!correctNumber)
            {
                Console.Write("Please enter a number: ");
                correctInput = Int32.TryParse(Console.ReadLine(), out input);

                if (correctInput && input == 88)
                {
                    Console.WriteLine("Lucky you...");
                    correctNumber = true;
                }
            }
        }

        // Using Elucid's algorithm, compute the LCM and HCF of two given integers
        public static void Question2(int A, int B)
        {
            Console.WriteLine(findHCF(A, B));
            Console.WriteLine(findLCM(A, B));
        }

        public static int findHCF(int A, int B)
        {
            int tempA = A;
            int tempB = B;

            while (tempA != tempB)
            {
                if (tempA > tempB)
                {
                    tempA -= tempB;
                }
                else
                {
                    tempB -= tempA;
                }
            }

            return tempA;
        }

        public static int findLCM(int A, int B)
        {
            return (A * B) / findHCF(A, B);
        }

        public static void Question3a()
        {
            Random r = new Random();
            int secretNumber = r.Next(0, 10);
            bool correctAnswer = false;
            int guess;
            int noOfGuesses = 0;

            while (!correctAnswer)
            {
                Console.Write("Please guess a number: ");
                bool legalGuess = Int32.TryParse(Console.ReadLine(), out guess);
                noOfGuesses++;

                if (guess == secretNumber)
                {
                    Console.WriteLine($"Congratulations! You took {noOfGuesses} attempts!");
                    correctAnswer = true;
                }
                else
                {
                    Console.WriteLine("Wrong Answer!");

                }
            }
        }

        public static void Question3b()
        {
            Random r = new Random();
            int secretNumber = r.Next(0, 10);
            bool correctAnswer = false;
            int guess;
            int noOfGuesses = 0;

            while (!correctAnswer)
            {
                Console.Write("Please guess a number: ");
                bool legalGuess = Int32.TryParse(Console.ReadLine(), out guess);
                noOfGuesses++;

                if (guess == secretNumber)
                {
                    Console.WriteLine($"Congratulations! You took {noOfGuesses} attempts!");

                    if (noOfGuesses < 3)
                    {
                        Console.WriteLine("You are a wizard!");
                    }
                    else if (noOfGuesses < 6)
                    {
                        Console.WriteLine("You are a good guess");
                    }
                    else
                    {
                        Console.WriteLine("You are lousy!");
                    }

                    correctAnswer = true;
                }
                else
                {
                    Console.WriteLine("Wrong Answer!");

                }
            }
        }

        public static double Question4(int input)
        {
            if (input == 0)
            {
                return 0;
            }

            Random r = new Random();
            double guess = r.Next(1, input + 1);

            while (Math.Abs(Math.Pow(guess, 2) - input) > 0.00001)
            {
                guess = (guess + input / guess) / 2;
            }

            return guess;
        }
    }
}
