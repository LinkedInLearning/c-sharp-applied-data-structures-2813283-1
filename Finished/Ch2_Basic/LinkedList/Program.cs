// Example file for C# Applied Data Structures by Joe Marini
// Using the LinkedList class

using System;
using System.Collections.Generic;

namespace LinkedListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define some strings that represent song names
            string[] songs = {"Shout", "Satisfaction", "Help!",
                            "Stairway to Heaven", "Come Sail Away",
                            "All Night Long", "Right Here Right Now"};

            // Create a LinkedList that holds strings
            LinkedList<string> mylist = new LinkedList<string>(songs);

            // Items can be added at the front or back of the list
            mylist.AddFirst("Africa");
            mylist.AddLast("The Twist");

            // Like other collections, a LinkedList can be iterated
            foreach (string s in mylist)
            {
                Console.WriteLine(s);
            }

            // First and Last properties return LinkedListNodes
            LinkedListNode<string> first = mylist.First;
            LinkedListNode<string> last = mylist.Last;
            Console.WriteLine(first.Value);
            Console.WriteLine(last.Value);

            // Items can be added or removed relative to an existing item
            mylist.AddAfter(first, "Here comes the sun");
            foreach (string s in mylist)
            {
                Console.WriteLine(s);
            }

            // Search for items in the list with Contains and Find
            Console.WriteLine(mylist.Contains("Satisfaction"));
            Console.WriteLine(mylist.Find("Help!"));

            // The list can then be traversed with those properties
            Console.WriteLine(first.Next.Value);
            Console.WriteLine(last.Previous.Value);
        }
    }
}
