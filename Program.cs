using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args) 
        {
            int number = Int32.Parse(Console.ReadLine());
            bool result = Solution.isPalindrome(number);
            Console.WriteLine($"Is {number} a palindrome? {result}");
        }
    }

    public class Solution 
    {
        public static bool isPalindrome(int x)
        {
            string integer_to_string = x.ToString();
            int integer_length = integer_to_string.Length;
            for (int i = 0; i < integer_length / 2; i++) 
            {
                if (integer_to_string[i] != integer_to_string[integer_length - i - 1]) 
                {
                    return false;
                }
            }
            return true;
        }
    }
}
