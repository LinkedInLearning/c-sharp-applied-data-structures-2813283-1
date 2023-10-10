// Example file for C# Applied Data Structures by Joe Marini
// Using the Dictionary class

using System;
using System.Collections.Generic;

namespace DictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dictionaries map keys to values. Keys must be unique
            Dictionary<string, string> fileTypes = new Dictionary<string, string>();

            // add some keys and values to the dictionary
            fileTypes.Add(".bmp", "Bitmap file");
            fileTypes.Add(".txt", "Plain text file");
            fileTypes.Add(".html", "HTML document");
            fileTypes.Add(".jpg", "JPEG image");

            // use the Count property to see how many items there are
            Console.WriteLine("Count: {0}", fileTypes.Count);

            // Trying to add an existing key will throw an exception
            // fileTypes.Add(".txt", "Just plain text");

            // The TryAdd function makes it convenient to see if there's a duplicate
            bool added = fileTypes.TryAdd(".txt", "Just plain text");
            Console.WriteLine("Added: {0}", added);

            // Dictionaries are also like associative arrays
            Console.WriteLine("Key value: {0}", fileTypes[".html"]);
            // This way, setting an existing key just overwrites the value
            fileTypes[".html"] = "Web Page";
            Console.WriteLine("Key value: {0}", fileTypes[".html"]);

            // See if the Dictionary contains an key or a value
            Console.WriteLine("Contains key: {0}", fileTypes.ContainsKey(".bmp"));
            Console.WriteLine("Contains value: {0}", fileTypes.ContainsValue("HTML document"));

            // Remove items
            fileTypes.Remove(".bmp");
            Console.WriteLine("Contains key: {0}", fileTypes.ContainsKey(".bmp"));
        }
    }
}
