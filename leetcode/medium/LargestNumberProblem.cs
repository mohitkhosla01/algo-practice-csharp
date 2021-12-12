using System;
using System.Text;

namespace algo_practice_csharp.leetcode.medium
{
    public class LargestNumberProblem
    {
        private void Main(string[] args)
        {
            LargestNumberProblem largestNumberProblem = new LargestNumberProblem();

            int[] nums1 = { 10, 2 };
            Console.WriteLine(largestNumberProblem.LargestNumber(nums1));

            int[] nums2 = { 3, 30, 34, 5, 9 };
            Console.WriteLine(largestNumberProblem.LargestNumber(nums2));

            int[] nums3 = { 1 };
            Console.WriteLine(largestNumberProblem.LargestNumber(nums3));

            int[] nums4 = { 10 };
            Console.WriteLine(largestNumberProblem.LargestNumber(nums4));

            int[] nums11 = { 1, 2, 3, 4, 5 };
            Console.WriteLine(largestNumberProblem.LargestNumber(nums11));

            int[] nums12 = { 5, 4, 3, 2, 1 };
            Console.WriteLine(largestNumberProblem.LargestNumber(nums12));

            int[] nums13 = { 9, 101, 109, 901 };
            Console.WriteLine(largestNumberProblem.LargestNumber(nums13));

            int[] nums14 = { 0, 0 };
            Console.WriteLine(largestNumberProblem.LargestNumber(nums14));

            int[] nums15 = { 0 };
            Console.WriteLine(largestNumberProblem.LargestNumber(nums15));
        }

        public string LargestNumber(int[] nums)
        {
            Array.Sort(nums, (int n1, int n2) =>
            {
                string s1 = n1.ToString() + n2.ToString();
                string s2 = n2.ToString() + n1.ToString();

                return s2.CompareTo(s1);
            });

            if(nums[0] == 0)
            {
                return "0";
            }

            StringBuilder sb = new StringBuilder();

            foreach(int n in nums)
            {
                sb.Append(n);
            }

            return sb.ToString();
        }
    }
}
