using _0_Base;
using System;

namespace _4_LargestPalindromeProduct
{
    class Program: SolverBase
    {
        /*
         A palindromic number reads the same both ways. 
         The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
         Find the largest palindrome made from the product of two 3-digit numbers.
         */

        static void Main(string[] args)
        {
            int answer = 906609;
            int solution = 0;

            int fourDigit = 1000;
            int threeDigit = 100;
            int palindrome = 0;

            for (int i = threeDigit; i < fourDigit; i++)
            {
                for (int j = threeDigit; j < fourDigit; j++)
                {
                    int tempPalindrome = GetPalindrome(i, j) ?? palindrome;

                    if(tempPalindrome > palindrome)
                    {
                        palindrome = tempPalindrome;
                    }
                }
            }

            solution = palindrome;
            ShowResults(4,solution);
        }

        private static int? GetPalindrome(int firstThreeDigit, int secondThreeDigit)
        {
            var foo = (firstThreeDigit * secondThreeDigit).ToString();

            if(foo.Length % 2 == 0)
            {
                int matchCounter = 0;

                for (int i = 0; i < foo.Length /2 ; i++)
                {
                    if(foo[i] == foo[(foo.Length-1) - i])
                    {
                        matchCounter++;
                    }
                }

                if (matchCounter == foo.Length / 2)
                {
                    Console.WriteLine($"Found new palindrom: {foo}");
                    return Convert.ToInt32(foo);
                }
            }

            return null;
        }
    }
}
