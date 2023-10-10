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
            // TODO: Create the list


            // TODO: Add some elements to the list from an existing array


            // TODO: Add individual items


            // TODO: Examine the Count and Capacity


            // TODO: Enumerate the items in the list with a foreach loop


            // TODO: Access any item by its index


            // TODO: Remove items from the list


            // TODO: Sort the list content


            // ** Searching List Content **/

            // TODO: Determine if a list contains a given item


            // TODO: The Exists function gives us a more customizable way to search
            // by using a predicate function to examine each element in the list


            // TODO: Use the Find function to search through items


            // TODO: The FindAll function can find multiple items


            // TODO: Use TrueForAll to see if a given condition is true for all elements

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
