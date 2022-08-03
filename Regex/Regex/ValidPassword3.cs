﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProblem
{
    class ValidPassword
    {
        public static string Password3 = "^[A-Z]+[a-zA-Z]{8,}[0-9]+$";
        public bool validatePassword(string Password)
        {
            return Regex.IsMatch(Password, Password3);
        }
    }
}