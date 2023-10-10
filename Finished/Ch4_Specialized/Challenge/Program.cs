// Example file for C# Applied Data Structures by Joe Marini
// Programming Challenge

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace Challenge
{
    class Program
    {
        static void PrintStringStats(string TheString)
        {
            string[] wordArray = TheString.Split(' ');

            // Count of words
            StringCollection wordCollection = new StringCollection();
            wordCollection.AddRange(wordArray);
            Console.WriteLine($"Word Count: {wordCollection.Count}");

            // Find the longest word
            int maxLen = 0;
            string maxWord = "";
            foreach (string w in wordCollection) {
                if (w.Length > maxLen) {
                    maxLen = w.Length;
                    maxWord = w;
                }
            }
            Console.WriteLine($"Longest word: {maxWord}");

            // Build the word count data
            Dictionary<string, int> wordDict = new Dictionary<string, int>();
            foreach (string w in wordCollection) {
                string key = w.ToLower();
                if (wordDict.ContainsKey(key)) {
                    wordDict[key]++;
                }
                else {
                    wordDict.Add(key, 1);
                }
            }

            foreach (string key in wordDict.Keys) {
                Console.WriteLine($"Word: {key}, Count: {wordDict[key]}");
            }
        }

        static void Main(string[] args)
        {
            string[] GettysburgAddress = {
                "Four score and seven years ago our",
                "fathers brought forth on this continent",
                "a new nation conceived in Liberty",
                "and dedicated to the proposition",
                "that all men are created equal",
                "Now we are engaged in a great civil war",
                "testing whether that nation",
                "or any nation so conceived and so dedicated",
                "can long endure",
                "We are met on a great battlefield of that war",
                "We have come to dedicate a portion of that field",
                "as a final resting place for those who",
                "here gave their lives that that nation might live",
                "It is altogether fitting",
                "and proper that we should do this"
            };
            
            StringBuilder sb = new StringBuilder();
            sb.AppendJoin(" ", GettysburgAddress);
            string TheText = sb.ToString();
            PrintStringStats(TheText);
        }
    }
}
