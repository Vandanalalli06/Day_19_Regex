using System;
using System.Collections.Generic;

namespace RegexProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To User Registration Problems");

           
            ValidFirstName validFirstName = new ValidFirstName();
            bool validTest1 = validFirstName.validateFirstName("Vandana");
            bool validTest2 = validFirstName.validateFirstName("va");
            Console.WriteLine("{0}  ", (validTest1) ? "Valid" : "Invalid");
            Console.ReadKey();
        }
    }
}









