using System;
using System.Collections.Generic;

namespace RegexProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To User Registration Problems");

           
            ValidLastName validLastName = new ValidLastName();
            bool validTest1 = validLastName.validateLastName("Dadi");
            bool validTest2 = validLastName.validateLastName("Da");
            Console.WriteLine("{0},{1}", (validTest1) ? "Valid" : "Invalid" , (validTest2) ? "Valid" : "Invalid");
            Console.ReadKey();
        }
    }
}









