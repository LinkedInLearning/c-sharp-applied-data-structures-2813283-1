// Example file for C# Applied Data Structures by Joe Marini
// Basic data structures

// strings are collections of characters, and are immutable
string s1 = "Hello World ";
char[] c1 = new char[] {'F','i','z','z','y',' ','B','u','z','z'};
string s2 = new string(c1);
s1 += s2;
Console.WriteLine(s1);

s2 = s2.ToUpper();
Console.WriteLine(s2);

// Be careful with string references
string s3 = "Hello ";
string s4 = s3;
s3 += "World";
Console.WriteLine(s4);

// Arrays are contiguous storage of the same variable type
int[] nums = new int[5];
int[] nums2 = {1,2,3,4,5};

// implicitly typed array
var a = new[] {"abc","def","ghi"}; // inferred to be str[]

// multiple type array
object[] objs = {"ABC",1,2,3,true,false};

// Tuples are lightweight data structures that group multiple data elements
(string, int, bool) t1 = ("abc", 15, false);
Console.WriteLine($"{t1.Item1}, {t1.Item3}");

(string s, int i, bool b) t2 = ("abc", 15, false);
Console.WriteLine($"{t2.s}, {t2.b}");

var t3 = (s: "def", i:25, b:true);
Console.WriteLine($"{t3.s}, {t3.b}");
