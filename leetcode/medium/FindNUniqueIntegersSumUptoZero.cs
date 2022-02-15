using System;

namespace algo_practice_csharp.leetcode.medium
{
    public class FindNUniqueIntegersSumUptoZero
    {
        private void Main(string[] args)
        {
            FindNUniqueIntegersSumUptoZero obj = new FindNUniqueIntegersSumUptoZero();

            Console.WriteLine(string.Join(",", obj.SumZero(5)));
            Console.WriteLine(string.Join(",", obj.SumZero(3)));
            Console.WriteLine(string.Join(",", obj.SumZero(1)));
        }

        public int[] SumZero(int n)
        {
            int[] arr = new int[n];
            int c = 0;

            if(n%2 != 0)
            {
                arr[c++] = 0;
            }

            for(int i=1; i<=n/2; ++i)
            {
                arr[c++] = i;
                arr[c++] = i*-1;
            }

            return arr;
        }
    }
}
