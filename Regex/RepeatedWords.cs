/*Find Repeating Words in a Sentence
Example Input: "This is is a repeated repeated word test."
Expected Output:
● is, repeated*/

using System;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace RegexPractice
{
    class RepeatingWords
    {
        public static void Execute()
        {
            string input = "This is is a repeated repeated word test.";

            Regex regex = new Regex(@"\b(\w+)\b\s+\1\b", RegexOptions.IgnoreCase);

            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups[1].Value);
            }


        }



    }
}
