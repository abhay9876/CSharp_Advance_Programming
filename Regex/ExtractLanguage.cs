/*Extract Programming Language Names from a Text
Example Text: "I love Java, Python, and JavaScript, but I haven't tried Go yet."
Expected Output:
● Java, Python, JavaScript, Go*/


using System;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace RegexPractice
{
    class ExtractLanguage
    {
        public static void Extract()
        {
            Console.WriteLine("Enter a Text with Cumputer Languages : ");
            string text = Console.ReadLine();
            string pattern = @"\b(Java|C#|Python|C)\b";
            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }

        }



    }
}
