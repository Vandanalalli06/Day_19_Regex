using System;
using System.Collections.Generic;

namespace RegexProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To User Registration Problems");


            ValidPassword validrule = new ValidPassword();
            bool validTest1 = validrule.validatePassword("Asdfgre");
            bool validTest2 = validrule.validatePassword("Abcdefghi4");
            Console.WriteLine("{0} {1} ", (validTest1) ? "Valid" : "Invalid", (validTest2) ? "Valid" : "Invalid");
            Console.ReadKey();
        }
    }
}









