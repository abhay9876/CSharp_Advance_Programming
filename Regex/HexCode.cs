/*Validate a Hex Color Code
A valid hex color:
● Starts with a #
● Followed by 6 hexadecimal characters (0-9, A-F, a-f).
Example Inputs & Outputs:

●  "#FFA500" → Valid
●  "#ff4500" → Valid
●  "#123" → Invalid (too short)*/


using System;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace RegexPractice
{
    class HexCode
    {
        public static void Valid()
        {
            Console.WriteLine("Enter Hex Code (Start with a '#'  6 hexadecimal characters (0-9, A-F, a-f) ) : ");
            string hexCode = Console.ReadLine();

            if (ValidationLicence(hexCode))
            {
                Console.WriteLine($"{hexCode} : Valid");
            }
            else
            {
                Console.WriteLine($"{hexCode} : Invalid");
            }
        }

        public static bool ValidationLicence(string hexCode)
        {
            string pattern = @"^#[A-Fa-f0-9]{6}$";
            return Regex.IsMatch(hexCode, pattern);
        }

    }
}
