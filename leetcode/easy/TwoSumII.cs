using System;

namespace algo_practice_csharp.leetcode.easy
{
    public class TwoSumII
    {
        private void Main(string[] args)
        {
            TwoSumII twoSumII = new TwoSumII();

            int[] nums1 = { 2, 7, 11, 15 };
            Console.WriteLine(string.Join(",", twoSumII.TwoSum(nums1, 9)));

            int[] nums2 = { 2, 3, 4 };
            Console.WriteLine(string.Join(",", twoSumII.TwoSum(nums2, 6)));

            int[] nums3 = { -1, 0 };
            Console.WriteLine(string.Join(",", twoSumII.TwoSum(nums3, -1)));

            int[] nums11 = { 1, 2 };
            Console.WriteLine(string.Join(",", twoSumII.TwoSum(nums11, 3)));

            int[] nums12 = { 1, 2, 3 };
            Console.WriteLine(string.Join(",", twoSumII.TwoSum(nums12, 3)));

            int[] nums13 = { 1, 2, 3 };
            Console.WriteLine(string.Join(",", twoSumII.TwoSum(nums13, 5)));
        }

        public int[] TwoSum(int[] numbers, int target)
        {
            for(int i=0; i<numbers.Length; ++i)
            {
                int currentTarget = target - numbers[i];

                int b = i + 1;
                int e = numbers.Length - 1;

                while (b <= e)
                {
                    int mid = b + (e - b) / 2;
                    
                    if(numbers[mid] == currentTarget)
                    {
                        int[] result = { i+1, mid+1 };
                        return result;
                    }
                    else if (numbers[mid] > currentTarget)
                    {
                        e = mid - 1;
                    }
                    else
                    {
                        b = mid + 1;
                    }
                }
            }

            return null;
        }
    }
}
