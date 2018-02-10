using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fopcs_day5
{
    public class Lecture
    {
        #region Program1()
        public static void Program1()
        {
            int[,] myArray = InitializeArray();
            int userInput = GetInput();
            int count = CountInteger(myArray, userInput);
            PrintOutput(count, userInput);
        }

        static int[,] InitializeArray()
        {
            return new int[,]
            {
                { 5, 3 }, { 2, 9 }, { 2, 9 },
                { 5, 1 }, { 7, 1 }, { 8, 3 },
                { 0, 3 }, { 2, 2 }, { 9, 7 }
            };
        }

        static int GetInput()
        {
            Console.WriteLine("Please enter a number (0-9): ");
            int input = Convert.ToInt32(Console.ReadLine());

            return input;
        }

        static int CountInteger(int[,] anArray, int integerToFind)
        {
            int count = 0;

            for (int i = 0; i < anArray.GetLength(0); i++)
            {
                for (int j = 0; j < anArray.GetLength(1); j++)
                {
                    if (anArray[i, j] == integerToFind)
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        static void PrintOutput(int count, int integerToFind)
        {
            if (count != 0)
            {
                Console.WriteLine($"The number of {integerToFind} is {count}");
            }
            else
            {
                Console.WriteLine($"There is no {integerToFind} in the array.");
            }
        }
        #endregion

        #region Program2()
        // uses custom class InputUtility
        public static void Program2()
        {
            int x = InputUtility.ReadInteger("Please enter x: ");
            int y = InputUtility.ReadInteger("Please enter y: ");
            Console.WriteLine($"You have entered {x} and {y}.");
        }
        #endregion
    }
}
