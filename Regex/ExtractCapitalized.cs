/*Extract All Capitalized Words from a Sentence
Example Text: "The Eiffel Tower is in Paris and the Statue of Liberty is in NewYork."
Expected Output:
● Eiffel, Tower, Paris, Statue, Liberty, New, York*/

using System;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace RegexPractice
{
    class ExtractCapitalized
    {
        public static void Extract()
        {
            Console.WriteLine("Enter a Text with Capitalized words : ");
            string text = Console.ReadLine();
            string pattern = @"\b[A-Z][a-z]*\b";
            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }

        }



    }
}
