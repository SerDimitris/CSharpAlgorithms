/*
 * Write a C# Sharp program to compute the sum of the two
 * numerical values. If the two values are the same,
 * return triple their sum.
 */

namespace TripleSumForEqualIntegers
{
    internal class Program
    {
        public static int SumInt(int x, int y)
        {
            return x == y ? (x + y) * 3 : x + y;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please insert first integer.");
                bool inputOne = int.TryParse(Console.ReadLine(), out int intOne);

                if (inputOne)
                {
                    while (true)
                    {
                        Console.WriteLine("Please insert second integer.");
                        bool inputTwo = int.TryParse(Console.ReadLine(), out int intTwo);

                        if (inputTwo)
                        {
                            Console.WriteLine("The int are{0}equal, so the result is: {1}", (intOne != intTwo ? " not " : " "), SumInt(intOne, intTwo));
                            break;
                        }
                        else Console.WriteLine("Invalid number. Try again.");
                    }
                    break;
                } else Console.WriteLine("Invalid number. Try again.");
            }
        }
    }
}