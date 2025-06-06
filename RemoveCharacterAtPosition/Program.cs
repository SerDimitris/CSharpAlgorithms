/*
 * Write a C# Sharp program to remove the character
 * at a given position in the string. The given position
 * will be in the range 0..(string length -1) inclusive.
 * 
 * Sample Input:
 * "Python", 1
 * "Python", 0
 * "Python", 4
 * 
 * Expected Output:
 * Pthon
 * ython
 * Pythn
 */
namespace RemoveCharacterAtPosition
{
    internal class Program
    {
        public static string RemoveChar(string s, int index)
        {
            return s.Remove(index, 1);
        }
        static void Main(string[] args)
        {
            string word = "Python";

            Console.WriteLine(RemoveChar(word, 1));
            Console.WriteLine(RemoveChar(word, 0));
            Console.WriteLine(RemoveChar(word, 4));
        }
    }
}
