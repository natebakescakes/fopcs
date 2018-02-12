using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalExercises
{
    public class ThrowDice
    {
        public static int RollDice()
        {
            return new Random().Next(1, 7);
        }

        public static void Question10()
        {
            bool found = false;

            while (!found)
            {
                int number = RollDice(); // inclusive minValue, exclusive maxValue
                Console.WriteLine($"{number}");

                if (number == 6)
                    found = true;
            }
        }

        public static void Question11()
        {
            bool equalDice = false;
            Random dice1 = new Random(1);
            Random dice2 = new Random(2);

            while (!equalDice)
            {
                int dice1Number = dice1.Next(1, 7);
                int dice2Number = dice2.Next(1, 7);

                Console.WriteLine($"{dice1Number} {dice2Number}");

                if (dice1Number == dice2Number)
                {
                    equalDice = !equalDice;
                }
            }
        }

        public static void Question12()
        {
            Random r = new Random();
            int count = 0;
            int prevNumber = -1;

            while (count != 1)
            {
                int currentNumber = r.Next(1, 7);
                Console.WriteLine(currentNumber);

                if (prevNumber == currentNumber)
                {
                    count++;
                }
                else
                {
                    count = 0;
                    prevNumber = currentNumber;
                }
            }
        }

        public static void Question13()
        {
            Random r = new Random();
            int count = 0;
            int prevNumber = -1;

            while (count != 2)
            {
                int currentNumber = r.Next(1, 7);
                Console.WriteLine(currentNumber);

                if (prevNumber == currentNumber)
                {
                    count++;
                }
                else
                {
                    count = 0;
                    prevNumber = currentNumber;
                }
            }
        }

        public static void Question14()
        {
            bool sequenceFound = false;
            Random r = new Random();
            int prevNumber = -1;

            while (!sequenceFound)
            {
                int currentNumber = r.Next(1, 7);
                Console.WriteLine(currentNumber);

                if (currentNumber == 2 && prevNumber == 1)
                {
                    sequenceFound = true;
                }
                else
                {
                    prevNumber = currentNumber;
                }
            }
        }
    }
}
