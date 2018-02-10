using System;

namespace fopcs_day5
{
    public class InputUtility
    {
        public static int ReadInteger(string s)
        {
            int input;
            bool parseSuccess = false;

            do
            {
                Console.Write(s);
                parseSuccess = Int32.TryParse(Console.ReadLine(), out input);
            } while (!parseSuccess);

            return input;
        }

        public static int ReadInteger()
        {
            return ReadInteger("Please enter an integer: ");
        }
    }
}
