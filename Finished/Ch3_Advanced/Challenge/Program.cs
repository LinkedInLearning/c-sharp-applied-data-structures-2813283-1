// Example file for C# Applied Data Structures by Joe Marini
// Programming Challenge

using System;
using System.Collections.Generic;

namespace Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] TestStatements = {
                "print('Hello World')",
                "if a(b[x]) == b(a[x])",
                "function t(x) { print('t(x)')}",
                "print 'Hello World')",
                "f(x) = g(x[2)",
                "{{[[(())]]}",
                "(",
                "}"
            };

            foreach (string TestStr in TestStatements) {
                bool Result = CheckBalanced(TestStr);

                Console.WriteLine($"Statement '{TestStr}' {(Result ? "is" : "is not")} balanced.");
            }
        }

        static bool CheckBalanced(string TestStatement) {
            Stack<char> tempStack = new ();

            foreach (char c in TestStatement) {
                if (c == '[' || c == '{' || c == '(') {
                    tempStack.Push(c);
                }

                if (c == ']' || c == '}' || c == ')') {
                    if (tempStack.Count == 0) {
                        return false;
                    }
                    char TestChar = tempStack.Pop();
                    if (c == ')' && TestChar != '(')
                        return false; 
                    if (c == ']' && TestChar != '[')
                        return false; 
                    if (c == '}' && TestChar != '{')
                        return false; 
                }
            }
            // if there are characters left in the stack, we are unbalanced
            if (tempStack.Count > 0) {
                return false;
            }

            return true;
        }
    }
}
