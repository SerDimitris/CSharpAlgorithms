/*
 * Write a C# Sharp program to check two given integers,
 * and return true if one of them is 30 or if their sum is 30.
 * 
 * Sample Input:
 * 30, 0
 * 25, 5
 * 20, 30
 * 20, 25
 * 
 * Expected Output:
 * True
 * True
 * True
 * False
 */

namespace Check30OrSumEquals30
{
    internal class Program
    {
        public static bool IsEqual(int x, int y)
        {
            return (x == 30 || y == 30 || x + y == 30);
        }
        static void Main(string[] args)
        {
            int[,] ints = { { 30, 0 }, { 25, 5 }, { 20, 30 }, { 20, 25 } };

            for (int i = 0; i < ints.GetLength(0); i++) Console.WriteLine(IsEqual(ints[i, 0], ints[i, 1]));
        }
    }
}
