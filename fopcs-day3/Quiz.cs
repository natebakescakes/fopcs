using System;

namespace fopcs_day3
{
    public class Quiz
    {
        public static void InitialAnswer()
        {
            bool accepted = false;
            int maxTries = 3, currentTry = 1;
            int correctPass = 123456;

            Console.WriteLine("Welcome to the bank of ISS");

            // Not a great conditional
            while(currentTry != maxTries)
            {
                Console.Write("Enter your PIN: ");
                if (correctPass == Int32.Parse(Console.ReadLine()))
                {
                    Console.WriteLine("PIN accepted. You can access your account now.");
                    accepted = true;
                    break;
                }
                else
                {
                    // Should add a conditional to check whether maxTries - currentTry != 0
                    Console.WriteLine($"Incorrect PIN. Please try again. You have {maxTries - currentTry} more tries");

                    // currentTry++ should be at the beginning, currentTry should initialise to 0
                    currentTry++;
                }
            }

            if (!accepted)
            {
                Console.WriteLine("Too many wrong PIN entries. Your account is now locked.");
            }
        }

        public static void RevisedAnswer()
        {
            bool accepted = false;
            int maxTries = 3, currentTry = 0;
            string correctPass = "123456";

            Console.WriteLine("Welcome to the bank of ISS");

            while (currentTry != maxTries && !accepted) // Write multiple conditions in the while loop
            {
                currentTry++;
                Console.Write("Enter your PIN: ");

                if (correctPass == Console.ReadLine())
                {
                    Console.WriteLine("PIN accepted. You can access your account now.");
                    accepted = true;
                }
                else if (maxTries - currentTry != 0)
                {
                    Console.WriteLine($"Incorrect PIN. Please try again. You have {maxTries - currentTry} more tries");
                }
                else
                {
                    Console.WriteLine("Too many wrong PIN entries. Your account is now locked.");
                }
            }
        }

        public static void LecturerAnswer()
        {
            string correctPin = "123456";
            string input;
            Console.WriteLine("Welcome to Bank of ISS");

            int count = 0;
            do
            {
                Console.Write("Enter your PIN: ");
                input = Console.ReadLine();
                count++;

                if (input == correctPin)
                {
                    Console.WriteLine("PIN accepted. Y(ou can access your account now.");
                }
                else
                {
                    switch (count)
                    {
                        case 1:
                            Console.WriteLine("Incorrect PIN. Please try again. You have 2 more tries");
                            break;
                        case 2:
                            Console.WriteLine("Incorrect PIN. Please try again. You have 1 more tries");
                            break;
                        case 3:
                            Console.WriteLine("Too many wrong PIN entries. Your account is locked.");
                            break;
                    }
                }
            } while (input != correctPin && count < 3);
        }
    }
}
