using System;
using System.Collections;
using System.Collections.Specialized;

namespace OrderedDictExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new OrderedDictionary object
            OrderedDictionary mod = new OrderedDictionary();

            // TODO: Add some keys and values in a particular order


            // TODO: Print the contents of the Dictionary


            // TODO: Remove an existing item and add a new one


            // TODO: Modify the value of an item in the dict


            // TODO: Add one final new item


        }

        static void PrintDictionary(OrderedDictionary theDict)
        {
            foreach (DictionaryEntry entry in theDict)
            {
                Console.WriteLine("Key = {0}, Value = {1}", entry.Key, entry.Value);
            }
            Console.WriteLine("---------------");
        }
    }
}
