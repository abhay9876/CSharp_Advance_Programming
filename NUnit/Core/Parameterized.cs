/*Testing Parameterized Tests
Problem:
Create a method IsEven(int number) that returns true if a number is even.
Use NUnit [TestCase] or MSTest [DataRow] to test this method with multiple
values like 2, 4, 6, 7, 9.*/


namespace Core
{
    public class Parameterized
    {
        public bool IsEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}