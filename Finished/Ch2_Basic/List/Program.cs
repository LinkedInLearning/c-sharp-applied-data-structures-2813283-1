// Example file for C# Applied Data Structures by Joe Marini
// Using the List class

using System;
using System.Collections.Generic;

namespace ListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define some strings to add to the list
            string[] comedians = {"Leo Gallagher", "Rodney Dangerfield",
                                "George Carlin", "Lenny Bruce",
                                "Eddie Murphy", "Louie Anderson"};
            // Create the list
            List<string> strList = new List<string>(10);

            // Add some elements to the list from an existing array
            strList.AddRange(comedians);

            // Add individual items
            strList.Add("Tina Fey");
            strList.Add("Amy Poehler");

            // Examine the Count and Capacity
            Console.WriteLine("Count and Capacity: {0}, {1}", strList.Count, strList.Capacity);

            // Enumerate the items in the list with a foreach loop
            PrintList(strList);

            // Access any item by its index
            Console.WriteLine("Item value: {0}", strList[4]);

            // Remove items from the list
            strList.RemoveAt(2);
            strList.Remove("Tina Fey");

            // Sort the list content
            strList.Sort();
            PrintList(strList);

            // ** Searching List Content **/

            // Determine if a list contains a given item
            Console.WriteLine(strList.Contains("Ron Gallagher"));

            // The Exists function gives us a more customizable way to search
            // by using a predicate function to examine each element in the list
            bool found = strList.Exists(x => x.Length > 15);
            Console.WriteLine("Item found: {0}", found);

            // Use the Find function to search through items
            string item = "";
            item = strList.Find(x => x.StartsWith("L"));
            Console.WriteLine("Item: {0}", item);

            // The FindAll function can find multiple items
            List<string> itemList = strList.FindAll(x => x.StartsWith("L"));
            PrintList(itemList);

            // Use TrueForAll to see if a given condition is true for all elements
            bool result = strList.TrueForAll(x => x.Length > 10);
            Console.WriteLine("Result: {0}", result);
        }

        static void PrintList(List<string> theList)
        {
            foreach (string str in theList)
            {
                Console.WriteLine(str);
            }
        }
    }
}
