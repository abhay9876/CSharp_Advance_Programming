/*Validate a Social Security Number (SSN)
Example Input: "My SSN is 123-45-6789."
Expected Output:
"123-45-6789" is valid
"123456789" is invalid*/

using System;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace RegexPractice
{
    class SecurityNumber
    {
        public static void Execute()
        {
            string input = "My SSN is 123-45-6789.";

            Regex regex = new Regex(@"\b\d{3}-\d{2}-\d{4}\b");

            Match match = regex.Match(input);

            if (match.Success)
                Console.WriteLine($"\"{match.Value}\" is valid");
            else
                Console.WriteLine("Invalid SSN format");


        }



    }
}
