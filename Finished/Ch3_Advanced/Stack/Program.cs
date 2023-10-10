// Example file for C# Applied Data Structures by Joe Marini
// Using the Stack class

using System;
using System.Collections.Generic;

namespace StackExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an empty stack
            Stack<string> myStack = new Stack<string>();

            // The Push function pushes new elements onto the stack
            myStack.Push("one");
            myStack.Push("two");
            myStack.Push("three");
            myStack.Push("four");
            myStack.Push("five");

            // The Count property indicates how many elements are on the stack
            Console.WriteLine("Item count: {0}", myStack.Count);

            // Stacks can be enumerated in place without changing the content
            foreach (string s in myStack)
            {
                Console.WriteLine(s);
            }

            // The Peek function examines the current top element but does not remove it
            string top = myStack.Peek();
            Console.WriteLine(top);

            // The Pop function removes an element from the top
            string item = myStack.Pop();
            Console.WriteLine(item);
            Console.WriteLine("Item count: {0}", myStack.Count);

            // Search for an element using Contains
            Console.WriteLine("Item found: {0}", myStack.Contains("five"));
            Console.WriteLine("Item found: {0}", myStack.Contains("four"));
        }
    }
}
