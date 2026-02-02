/* use of a lambda expression within the LINQ OrderBy method to sort a list of strings based on their 
length in ascending order. The resulting sorted list is then printed to the console.*/


using System;
namespace SortList
{
    public class Sorting
    {
        public static void GetSort()
        {
            List<string> names = new List<string> { "ABC", "KLMN", "UI", "G", "XYZAF" };

            var sortName = names.OrderBy(n => n.Length).ToList();

            Console.WriteLine("Names Sorted by length :");
            foreach (var name in sortName)
            {
                Console.WriteLine(name);
            }
        }
    }
}