/*Extract Links from a Web Page
Example Text: "Visit https://www.google.com and http://example.org for more
info."

Expected Output:
● https://www.google.com, http://example.org*/

using System;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace RegexPractice
{
    class ExtractLinks
    {
        public static void Extract()
        {
            Console.WriteLine("Enter a Text with Links : ");
            string text = Console.ReadLine();
            string pattern = @"https?://[^\s]+";
            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }

        }



    }
}
