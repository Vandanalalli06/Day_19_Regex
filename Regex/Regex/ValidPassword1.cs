using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProblem
{
    class ValidPassword
    {
        public static string Password1 = "([A-Z]{1}[A-Za-z]{7,})";
        public bool validatePassword(string Password)
        {
            return Regex.IsMatch(Password, Password1);
        }
    }
}