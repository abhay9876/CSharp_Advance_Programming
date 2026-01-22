/*Validate a Username
A valid username:
● Can only contain letters (a-z, A-Z), numbers (0-9), and underscores (_)
● Must start with a letter
● Must be between 5 to 15 characters long
Example Inputs & Outputs:
● "user_123" → Valid
●  "123user" → Invalid (starts with a number)
●  "us" → Invalid (too short)*/


using System;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace RegexPractice
{
    class ValidateUserName
    {
        public static void Valid()
        {
            Console.WriteLine("Enter user Name (Start with a letter and length of 5-15 ):)");
            string userName = Console.ReadLine();

            if (ValidationUser(userName))
            {
                Console.WriteLine($"{userName} : Valid");
            }
            else
            {
                Console.WriteLine($"{userName} : Invalid");
            }
        }

        public static bool ValidationUser(string name)
        {
            string pattern = @"^[A-Za-z][A-Za-z0-9_]{4,14}$";
            return Regex.IsMatch(name, pattern);
        }

    }
}
