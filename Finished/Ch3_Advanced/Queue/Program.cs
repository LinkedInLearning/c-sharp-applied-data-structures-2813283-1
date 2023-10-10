// Example file for C# Applied Data Structures by Joe Marini
// Using the Queue class

using System;
using System.Collections.Generic;

namespace QueueExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an empty Queue that holds strings
            Queue<string> myQ = new Queue<string>();

            // Add items to the end of the queue
            myQ.Enqueue("one");
            myQ.Enqueue("two");
            myQ.Enqueue("three");
            myQ.Enqueue("four");
            myQ.Enqueue("five");

            // use the count property to see how many items there are
            Console.WriteLine("Item count: {0}", myQ.Count);

            // Queues can be iterated without changing the structure
            foreach (string s in myQ)
            {
                Console.WriteLine(s);
            }

            // peek at the front of the queue
            string str = myQ.Peek();
            Console.WriteLine("The first item is {0}", str);

            // remove items from the front of the queue
            str = myQ.Dequeue();
            Console.WriteLine("Dequeued item is {0}", str);
            str = myQ.Dequeue();
            Console.WriteLine("Dequeued item is {0}", str);
            Console.WriteLine("Item count: {0}", myQ.Count);

            // see if the queue contains an item
            Console.WriteLine("Queue contains 'one': {0}", myQ.Contains("one"));
            Console.WriteLine("Queue contains 'four': {0}", myQ.Contains("four"));

            // Remove all the items
            myQ.Clear();
            Console.WriteLine("Item count: {0}", myQ.Count);
        }
    }
}
