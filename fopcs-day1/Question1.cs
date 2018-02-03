using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program that will print out your detail in the following format:
 * Line 1: Name
 * Line 2: Email
 */

namespace fopcs_day1
{
    class Question1
    {
        public static void question1()
        { 
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your email: ");
            string email = Console.ReadLine();

            Console.WriteLine($"{name}");
            Console.WriteLine($"{email}");
        }
    }
}
