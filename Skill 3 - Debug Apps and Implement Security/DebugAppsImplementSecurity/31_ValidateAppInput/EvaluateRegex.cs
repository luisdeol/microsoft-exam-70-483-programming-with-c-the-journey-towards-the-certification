using System;
using System.Text.RegularExpressions;

namespace _31_ValidateAppInput
{
    public static class EvaluateRegex
    {
        public static void GetExample()
        {
            const string email = "luis_felipe@gmail.com";
            var valid = ValidateEmail(email);


            Console.WriteLine($"The e-mail {email} is {(valid ? "" : "not")} valid");

            Console.ReadLine();
        }

        static bool ValidateEmail(string email)
        {
            const string pattern = @"^[a-z0-9._]+@[a-z0-9]+\.[a-z]+\.?([a-z]+)?$";

            return Regex.Match(email, pattern).Success;
        }
    }
}
