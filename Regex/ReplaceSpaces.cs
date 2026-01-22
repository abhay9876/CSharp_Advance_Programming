/*Replace Multiple Spaces with a Single Space
Example Input: "This is an example with multiple spaces."
Expected Output: "This is an example with multiple spaces."*/

using System;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace RegexPractice
{
    class ReplaceSpaces
    {
        public static void Execute()
        {
            Console.WriteLine("Enter a Text with Multiple Spaces : ");
            string text = Console.ReadLine();
            string pattern = @"\s+";
            string result = Regex.Replace(text, pattern, " ");
            Console.WriteLine(result);


        }



    }
}
