/*
 * Write a C# Sharp program to get the absolute difference
 * between n and 51. If n is broader than 51 return triple
 * the absolute difference.
 * 
 * Sample Input:
 * 53
 * 30
 * 51
 * 
 * Expected Output:
 * 6
 * 21
 * 0
 */

namespace AbsoluteDifferenceWithTripleForGreater
{
    internal class Program
    {
        public static int AbsDiff(int x)
        {
            return x > 51 ? Math.Abs(x - 51) * 3 : Math.Abs(x - 51);
        }
        static void Main(string[] args)
        {
            int[] input = { 53, 30, 51 };

            for (int i = 0; i < input.Length; i++) Console.WriteLine(AbsDiff(input[i]));
        }
    }
}