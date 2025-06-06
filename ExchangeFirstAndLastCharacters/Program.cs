/*
 * Write a C# Sharp program to exchange the first
 * and last characters in a given string and return the new string.
 * 
 * Sample Input:
 * "abcd"
 * "a"
 * "xy"
 * 
 * Expected Output:
 * dbca
 * a
 * yx
 */

namespace ExchangeFirstAndLastCharacters
{
    internal class Program
    {
        public static string SwapFirstAndLast(string s)
        {
            string subString;
            char a = s[0];
            char b = s[^1];

            if (s.Length > 2)
            {


                return subString = b + s.Substring(1, s.Length - 2) + a;

            }
            else return s;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
