using System;

namespace algo_practice_csharp.leetcode.easy
{
    public class SquaresOfSortedArray
    {
        private void Main(string[] args)
        {
            SquaresOfSortedArray squaresOfSortedArray = new SquaresOfSortedArray();

            int[] nums1 = { -4, -1, 0, 3, 10 };
            Console.WriteLine(string.Join(",", squaresOfSortedArray.SortedSquares(nums1)));

            int[] nums2 = { -7, -3, 2, 3, 11 };
            Console.WriteLine(string.Join(",", squaresOfSortedArray.SortedSquares(nums2)));

            int[] nums11 = { 1 };
            Console.WriteLine(string.Join(",", squaresOfSortedArray.SortedSquares(nums11)));

            int[] nums12 = { 1, 2 };
            Console.WriteLine(string.Join(",", squaresOfSortedArray.SortedSquares(nums12)));

            int[] nums13 = { -3, -2, -1 };
            Console.WriteLine(string.Join(",", squaresOfSortedArray.SortedSquares(nums13)));

            int[] nums14 = { 3, 4, 4, 5 };
            Console.WriteLine(string.Join(",", squaresOfSortedArray.SortedSquares(nums14)));

            int[] nums15 = { 3, 3, 4, 5 };
            Console.WriteLine(string.Join(",", squaresOfSortedArray.SortedSquares(nums15)));

            int[] nums16 = { 3, 4, 5, 5 };
            Console.WriteLine(string.Join(",", squaresOfSortedArray.SortedSquares(nums16)));

            int[] nums17 = { -5, -5, -4, -3 };
            Console.WriteLine(string.Join(",", squaresOfSortedArray.SortedSquares(nums17)));

            int[] nums18 = { -5, -4, -3, -3 };
            Console.WriteLine(string.Join(",", squaresOfSortedArray.SortedSquares(nums18)));
        }

        public int[] SortedSquares(int[] nums)
        {
            int b = 0, e = nums.Length - 1;

            int[] newNums = new int[nums.Length];
            int newNumsIndex = nums.Length - 1;

            while(b <= e)
            {
                int bSquare = (int)Math.Pow(Math.Abs(nums[b]), 2);
                int eSquare = (int)Math.Pow(Math.Abs(nums[e]), 2);

                if (bSquare < eSquare) {
                    newNums[newNumsIndex] = eSquare;
                    --e;
                }
                else
                {
                    newNums[newNumsIndex] = bSquare;
                    ++b;
                }
                --newNumsIndex;
            }

            return newNums;
        }
    }
}
