/*
 * Write a C# Sharp program to create a string where 'if'
 * is added to the front of a given string. If the string
 * already begins with 'if', return it unchanged.
 * 
 * Sample Input:
 * "if else"
 * "else"
 * 
 * Expected Output:
 * if else
 * if else
 */

namespace AddIfToStringIfAbsent
{
    internal class Program
    {
        public static string AddString(string s)
        {
            if (s.StartsWith("if")) return s;
            else return "if " + s;
        }
        static void Main(string[] args)
        {
            string inputFirst = "if else";
            string inputSecond = "else";

            Console.WriteLine(AddString(inputFirst));
            Console.WriteLine(AddString(inputSecond));
        }
    }
}
