/*
 * Write a C# Sharp program to check a given integer
 * and return true if it is within 10 of 100 or 200.
 * 
 * Sample Input:
 * 103
 * 90
 * 89
 * 
 * Expected Output:
 * 
 * True
 * True
 * False
 * */

namespace Within10Of100Or200
{
    internal class Program
    {
        static bool IsWithin(int x)
        {
            return (x % 10 == 0) || (x > 100 && x <= 200);
        }
        static void Main(string[] args)
        {
            int[] arr = { 103, 90, 89 };

            for (int i = 0; i < arr.Length; i++) Console.WriteLine(IsWithin(i));
        }
    }
}
