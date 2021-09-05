using System;
using System.Collections.Generic;

namespace algo_practice_csharp.leetcode.easy
{
    public class ContainsDuplicateProblem
    {
        private void Main(string[] args)
        {
            ContainsDuplicateProblem containsDuplicateProblem = new ContainsDuplicateProblem();

            int[] nums1 = { 1, 2, 3, 1 };
            Console.WriteLine(containsDuplicateProblem.ContainsDuplicate(nums1));

            int[] nums2 = { 1, 2, 3, 4 };
            Console.WriteLine(containsDuplicateProblem.ContainsDuplicate(nums2));

            int[] nums3 = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
            Console.WriteLine(containsDuplicateProblem.ContainsDuplicate(nums3));
        }

        public bool ContainsDuplicate(int[] nums)
        {
            Dictionary<int, int> numCount = new Dictionary<int, int>();

            foreach(int num in nums)
            {
                if(numCount.ContainsKey(num))
                {
                    return true;
                }
                else
                {
                    numCount.Add(num, 1);
                }
            }

            return false;
        }
    }
}
