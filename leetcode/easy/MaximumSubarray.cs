using System;

namespace algo_practice_csharp.leetcode.easy
{
    public class MaximumSubarray
    {
        private void Main(string[] args)
        {
            MaximumSubarray maximumSubArray = new MaximumSubarray();

            int[] nums1 = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            Console.WriteLine(maximumSubArray.MaxSubArray(nums1));

            int[] nums2 = { 1 };
            Console.WriteLine(maximumSubArray.MaxSubArray(nums2));

            int[] nums3 = { 5, 4, -1, 7, 8 };
            Console.WriteLine(maximumSubArray.MaxSubArray(nums3));

            int[] nums4 = { -1 };
            Console.WriteLine(maximumSubArray.MaxSubArray(nums4));

            int[] nums11 = { -2, -3, 4, -1, -2, 1, 5, -3 };
            Console.WriteLine(maximumSubArray.MaxSubArray(nums11));

            int[] nums12 = { 1, 2, 3, 4, 5 };
            Console.WriteLine(maximumSubArray.MaxSubArray(nums12));

            int[] nums13 = { 1, 2, 0, 4, 5 };
            Console.WriteLine(maximumSubArray.MaxSubArray(nums13));

            int[] nums14 = { 1, 2, -1, 4, 5 };
            Console.WriteLine(maximumSubArray.MaxSubArray(nums14));

            int[] nums15 = { 1, 2, -2, 4, 5 };
            Console.WriteLine(maximumSubArray.MaxSubArray(nums15));

            int[] nums16 = { 1, 2, -5, 4, 5 };
            Console.WriteLine(maximumSubArray.MaxSubArray(nums16));
        }

        public int MaxSubArray(int[] nums)
        {
            int sum = Int32.MinValue;
            int currentSum = 0;

            for(int i=0; i<nums.Length; ++i)
            {
                currentSum += nums[i];

                if (currentSum > sum)
                {
                    sum = currentSum;
                }
                if (currentSum < 0)
                {
                    currentSum = 0;
                }
            }

            return sum;
        }
    }
}
