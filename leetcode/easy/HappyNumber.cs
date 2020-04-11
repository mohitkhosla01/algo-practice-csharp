using System;
using System.Collections.Generic;

namespace algo_practice_csharp.leetcode.easy
{
    class HappyNumber
    {
        private void Main(string[] args)
        {
            HappyNumber happyNumber = new HappyNumber();

            Console.WriteLine(happyNumber.IsHappy(19));
            Console.WriteLine(happyNumber.IsHappy(25));
            Console.WriteLine(happyNumber.IsHappy(31));
            Console.WriteLine(happyNumber.IsHappy(0));
        }
        private bool IsHappy(int n)
        {
            HashSet<int> hs = new HashSet<int>();

            while (true)
            {
                int t = 0;
                while(n != 0)
                {
                    int r = n % 10;
                    t += (r * r);
                    n /= 10;
                }

                if (t == 1)
                {
                    return true;
                }
                else if (hs.Contains(t))
                {
                    return false;
                }
                else
                {
                    hs.Add(t);
                    n = t;
                }
            }
        }
    }
}
