using System;
using System.Collections.Generic;

namespace RegexProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To User Registration Problems");


            ValidEmail validEmail = new ValidEmail();
            bool validTest1 = validEmail.validateEmail("abc.xyz@bl.co.in");
            bool validTest2 = validEmail.validateEmail("abc.xyz@in");
            Console.WriteLine("{0} {1} ", (validTest1) ? "Valid" : "Invalid", (validTest2) ? "Valid" : "Invalid");
            Console.ReadKey();
        }
    }
}









