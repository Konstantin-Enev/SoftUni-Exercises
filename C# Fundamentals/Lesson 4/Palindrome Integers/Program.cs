using System;

namespace Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool isPalindrome = false;

            while(input != "END")
            {
                Console.WriteLine(PalindromeChecker(input,isPalindrome).ToString().ToLower());
                input = Console.ReadLine();
            }
        }

        private static bool PalindromeChecker(string number, bool isPalindrome)
        {
            var reverseNumber = "";

            for(int i = number.Length - 1; i >= 0; i--)
            {
                char symbol = number[i];
                reverseNumber += symbol;
            }
            if(reverseNumber == number)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
