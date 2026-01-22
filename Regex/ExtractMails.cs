/*Extract All Email Addresses from a Text
Example Text: "Contact us at support@example.com and info@company.org"
Expected Output:
● support@example.com
● info@company.org*/


using System;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace RegexPractice
{
    class ExtractMails
    {
        public static void Extract()
        {
            Console.WriteLine("Enter a Text with Emails : ");
            string text = Console.ReadLine();
            string pattern = @"[A-Za-z0-9_.]+@[A-Za-z]+\.[A-Za-z]{2,}";
            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }

        }



    }
}
