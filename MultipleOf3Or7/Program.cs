/*
 * Write a C# Sharp program to check if a given
 * positive number is a multiple of 3 or 7.
 * 
 * Sample Input:
 * 3
 * 14
 * 12
 * 37
 * 
 * Expected Output:
 * True
 * True
 * True
 * False
 */

namespace MultipleOf3Or7
{
    internal class Program
    {
        static bool IsMultipleOfThreeOrSeven(int x)
        {
            return x % 3 == 0 || x % 7 == 0;
        }
        static void Main(string[] args)
        {
            int numb1 = 3;
            int numb2 = 14;
            int numb3 = 12;
            int numb4 = 37;

            Console.WriteLine(IsMultipleOfThreeOrSeven(Math.Abs(numb1)));
            Console.WriteLine(IsMultipleOfThreeOrSeven(Math.Abs(numb2)));
            Console.WriteLine(IsMultipleOfThreeOrSeven(Math.Abs(numb3)));
            Console.WriteLine(IsMultipleOfThreeOrSeven(Math.Abs(numb4)));
        }
    }
}
