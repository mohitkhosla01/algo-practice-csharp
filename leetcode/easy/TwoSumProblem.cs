using System;
using System.Collections.Generic;

namespace algo_practice_csharp.leetcode.easy
{
    public class TwoSumProblem
    {
        private void Main(string[] args)
        {
            TwoSumProblem twoSum = new TwoSumProblem();

            int[] nums1 = { 2, 7, 11, 15 };
            Console.WriteLine(string.Join(",", twoSum.TwoSum(nums1, 9)));

            int[] nums2 = { 2, 3, 4 };
            Console.WriteLine(string.Join(",", twoSum.TwoSum(nums2, 6)));

            int[] nums3 = { -1, 0 };
            Console.WriteLine(string.Join(",", twoSum.TwoSum(nums3, -1)));

            int[] nums4 = { 3, 2, 4 };
            Console.WriteLine(string.Join(",", twoSum.TwoSum(nums4, 6)));

            int[] nums5 = { 3, 3 };
            Console.WriteLine(string.Join(",", twoSum.TwoSum(nums5, 6)));

            int[] nums6 = { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 };
            Console.WriteLine(string.Join(",", twoSum.TwoSum(nums6, 11)));

            int[] nums11 = { 1, 2 };
            Console.WriteLine(string.Join(",", twoSum.TwoSum(nums11, 3)));

            int[] nums12 = { 1, 2, 3 };
            Console.WriteLine(string.Join(",", twoSum.TwoSum(nums12, 3)));

            int[] nums13 = { 1, 2, 3 };
            Console.WriteLine(string.Join(",", twoSum.TwoSum(nums13, 5)));

            int[] nums21 = { 8, 3, 4, 2, 7, 11, 15 };
            Console.WriteLine(string.Join(",", twoSum.TwoSum(nums21, 9)));
        }

        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; ++i)
            {
                if(dict.ContainsKey(target - nums[i]) && dict[target - nums[i]] != i)
                {
                    int[] result = { dict[target - nums[i]], i };
                    return result;
                }
                else if(!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], i);
                }
            }

            return null;
        }
    }
}
