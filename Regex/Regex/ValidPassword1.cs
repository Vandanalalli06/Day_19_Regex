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
        public static string Password1 = "^[a-z A-Z]{8,}$";
        public bool validatePassword(string Password)
        {
            return Regex.IsMatch(Password, Password1);
        }
    }
}