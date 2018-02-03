using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program that would request for your name and print a greeting like this:
 * Good Morning John
 * where John is the name you had input
 */

namespace fopcs_day1
{
    class Question2
    {
        public static void question2()
        {
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Good Morning {name}");
        }
    }
}
