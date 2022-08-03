using System;
using System.Collections.Generic;

namespace RegexProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To User Registration Problems");


            ValidMobile validmobile = new ValidMobile();
            bool validTest1 = validmobile.validateString("9156784");
            bool validTest2 = validmobile.validateString("91 6875649781");
            Console.WriteLine("{0} {1} ", (validTest1) ? "Valid" : "Invalid", (validTest2) ? "Valid" : "Invalid");
            Console.ReadKey();
        }
    }
}









