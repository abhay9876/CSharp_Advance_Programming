/*Testing List Operations
Problem:
Create a ListManager class that has the following methods:
● AddElement(List<int> list, int element): Adds an element to a list.
● RemoveElement(List<int> list, int element): Removes an element from a
list.
● GetSize(List<int> list): Returns the size of the list.

Write NUnit or MSTest tests to verify that:
 Elements are correctly added.
 Elements are correctly removed.
 The size of the list is updated correctly.*/


namespace Core
{
    public class ListManager
    {

        public void AddElement(List<int> list, int element)
        {
            list.Add(element);

        }

        public void RemoveElement(List<int> list, int element)
        {
            list.Remove(element);
        }
        public int GetSize(List<int> list)
        {
            return list.Count;
        }


    }
}