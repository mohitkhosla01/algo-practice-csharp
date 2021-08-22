using System;

namespace algo_practice_csharp.leetcode.easy
{
    public class PalindromeNumber
    {
        private void Main(string[] args)
        {
            PalindromeNumber palindromeNumber = new PalindromeNumber();

            Console.WriteLine("-100: " + palindromeNumber.IsPalindrome(-100));
            Console.WriteLine("-1: " + palindromeNumber.IsPalindrome(-1));
            Console.WriteLine("0: " + palindromeNumber.IsPalindrome(0));
            Console.WriteLine("1: " + palindromeNumber.IsPalindrome(1));
            Console.WriteLine("10: " + palindromeNumber.IsPalindrome(10));
            Console.WriteLine("3055: " + palindromeNumber.IsPalindrome(3055));
            Console.WriteLine("4224: " + palindromeNumber.IsPalindrome(4224));
            Console.WriteLine("4444: " + palindromeNumber.IsPalindrome(4444));
            
            Console.WriteLine("-121: " + palindromeNumber.IsPalindrome(-121));
            Console.WriteLine("-101: " + palindromeNumber.IsPalindrome(-101));
            Console.WriteLine("10: " + palindromeNumber.IsPalindrome(10));
            Console.WriteLine("121: " + palindromeNumber.IsPalindrome(121));
        }

        public bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }
            else if (x == 0)
            {
                return true;
            }
            else
            {
                int t = x;
                int t1 = 0;
                while (t != 0)
                {
                    t1 = (t1 * 10) + (t % 10);
                    t /= 10;
                }
                if (x == t1)
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
}
