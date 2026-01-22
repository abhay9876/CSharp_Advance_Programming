/*Validate a Credit Card Number (Visa, MasterCard, etc.)
● A Visa card number starts with 4 and has 16 digits.
● A MasterCard starts with 5 and has 16 digits.*/




using System;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace RegexPractice
{
    class CreditCard
    {
        public static void Valid()
        {
            Console.WriteLine("Enter CreditCard Number : ");
            string cc = Console.ReadLine();

            if (ValidationCC(cc))
            {
                Console.WriteLine($"{cc} : Valid");
            }
            else
            {
                Console.WriteLine($"{cc} : Invalid");
            }
        }

        public static bool ValidationCC(string cc)
        {
            string pattern = @"^(4\d{15}|5\d{15})$";
            return Regex.IsMatch(cc, pattern);
        }

    }
}
