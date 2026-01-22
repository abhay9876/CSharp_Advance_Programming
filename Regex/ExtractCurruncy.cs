/*Extract Currency Values from a Text
Example Text: "The price is $45.99, and the discount is $ 10.50."
Expected Output:
● $45.99, 10.50*/

using System;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace RegexPractice
{
    class ExtractCurruncy
    {
        public static void Extract()
        {
            Console.WriteLine("Enter a Text with Curruncy : ");
            string text = Console.ReadLine();
            string pattern = @"\b\$\d+\.\d{2}\b";
            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }

        }



    }
}
