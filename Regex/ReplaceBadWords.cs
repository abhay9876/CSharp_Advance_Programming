/*Censor Bad Words in a Sentence
Given a list of bad words, replace them with ****.
Example Input: "This is a damn bad example with some stupid words."
Expected Output: "This is a **** bad example with some **** words."*/


using System;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace RegexPractice
{
    class ReplaceBadWords
    {
        public static void Execute()
        {
            Console.WriteLine("Enter a Text with Bad Words : ");
            string text = Console.ReadLine();
            string pattern = @"\b(damn|stupid)\b";
            string result = Regex.Replace(text, pattern, "****", RegexOptions.IgnoreCase);
            Console.WriteLine(result);


        }



    }
}
