using System;

namespace algo_practice_csharp.leetcode.medium
{
    public class KthLargestElementInArray
    {
        private void Main(string[] args)
        {
            KthLargestElementInArray kthLargestElementInArray = new KthLargestElementInArray();

            int[] nums1 = { 3, 2, 1, 5, 6, 4 };
            Console.WriteLine(kthLargestElementInArray.FindKthLargest(nums1, 2));

            int[] nums2 = { 3, 2, 3, 1, 2, 4, 5, 5, 6 };
            Console.WriteLine(kthLargestElementInArray.FindKthLargest(nums2, 4));

            int[] nums11 = { 1, 1, 1, 1, 1 };
            Console.WriteLine(kthLargestElementInArray.FindKthLargest(nums11, 2));

            int[] nums12 = { -3, 5, 4, -2, 1 };
            Console.WriteLine(kthLargestElementInArray.FindKthLargest(nums12, 4));
        }

        public int FindKthLargest(int[] nums, int k)
        {
            Array.Sort(nums);
            return nums[nums.Length - k];
        }
    }
}
