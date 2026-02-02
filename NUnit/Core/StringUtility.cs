/*Testing String Utility Methods
Problem:
Create a StringUtils class with the following methods:
● Reverse(string str): Returns the reverse of a given string.
● IsPalindrome(string str): Returns true if the string is a palindrome.
● ToUpperCase(string str): Converts a string to uppercase.
Write NUnit or MSTest test cases to verify that these methods work correctly.*/

namespace Core
{
    public class StringUtils
    {
        public string Reverse(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public bool IsPalindrome(string str)
        {
            int i = 0;
            int j = str.Length - 1;
            while (i < j)
            {
                if (str[i] != str[j])
                {
                    return false;
                }
                i++;
                j--;
            }
            return true;
        }

        public string ToUpperCases(string str)
        {
            return str.ToUpper();
        }
    }
}