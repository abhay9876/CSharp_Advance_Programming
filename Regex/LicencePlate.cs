/*Validate a License Plate Number
License plate format: Starts with two uppercase letters, followed by four digits.
Example: "AB1234" is valid, but "A12345" is invalid.*/

using System;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace RegexPractice
{
    class LicensePlate
    {
        public static void Valid()
        {
            Console.WriteLine("Enter Licence Number (Start with Two uppercase letter followed by four digits ) : ");
            string number = Console.ReadLine();

            if (ValidationLicence(number))
            {
                Console.WriteLine($"{number} : Valid");
            }
            else
            {
                Console.WriteLine($"{number} : Invalid");
            }
        }

        public static bool ValidationLicence(string num)
        {
            string pattern = @"^[A-Z]{2}[0-9]{4}$";
            return Regex.IsMatch(num, pattern);
        }

    }
}
