/*Extract Dates in dd/mm/yyyy Format
Example Text: "The events are scheduled for 12/05/2023, 15/08/2024, and 29/02/2020."
Expected Output:
● 12/05/2023, 15/08/2024, 29/02/2020*/


using System;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace RegexPractice
{
    class ExtractDate
    {
        public static void Extract()
        {
            Console.WriteLine("Enter a Text with dates : ");
            string text = Console.ReadLine();
            string pattern = @"\b[0-9]{2}/[0-9]{2}/[0-9]{4}\b";
            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }

        }



    }
}
