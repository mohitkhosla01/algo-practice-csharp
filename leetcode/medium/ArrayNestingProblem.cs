using System;
using System.Collections.Generic;

namespace algo_practice_csharp.leetcode.medium
{
    public class ArrayNestingProblem
    {
        private void Main(String[] args)
        {
            ArrayNestingProblem arrayNestingProblem = new ArrayNestingProblem();

            int[] nums1 = { 0 };
            Console.WriteLine(arrayNestingProblem.ArrayNesting(nums1));

            int[] nums2 = { 0, 1 };
            Console.WriteLine(arrayNestingProblem.ArrayNesting(nums2));

            int[] nums3 = { 0, 1, 2 };
            Console.WriteLine(arrayNestingProblem.ArrayNesting(nums2));

            int[] nums4 = { 0, 2, 1 };
            Console.WriteLine(arrayNestingProblem.ArrayNesting(nums2));

            int[] nums5 = { 2, 0, 1 };
            Console.WriteLine(arrayNestingProblem.ArrayNesting(nums2));

            int[] nums6 = { 1, 0, 2 };
            Console.WriteLine(arrayNestingProblem.ArrayNesting(nums6));

            int[] nums7 = { 1, 2, 0 };
            Console.WriteLine(arrayNestingProblem.ArrayNesting(nums7));

            //int[] nums11 = { 5, 4, 0, 3, 1, 6, 2 };
            //Console.WriteLine(arrayNestingProblem.ArrayNesting(nums11));

            //int[] nums12 = { 0, 1, 2 };
            //Console.WriteLine(arrayNestingProblem.ArrayNesting(nums12));

            //int[] nums13 = { 6, 0, 3, 2, 5, 7, 1, 4 };
            //Console.WriteLine(arrayNestingProblem.ArrayNesting(nums13));
        }

        public int ArrayNesting(int[] nums)
        {
            int maxLength = 0;

            Dictionary<int, int> maxCounts = new Dictionary<int, int>();

            for(int i=0; i<nums.Length; ++i)
            {
                int[] currentNums = new int[nums.Length];
                int currentMaxLength = 0;

                int currentNum = nums[i];

                while(true)
                {
                    if(maxCounts.ContainsKey(currentNum))
                    {
                        currentMaxLength += maxCounts[currentNum];
                        maxLength = currentMaxLength > maxLength ? currentMaxLength : maxLength;
                        break;
                    }
                    else if(currentMaxLength != 0 && currentNums[0] == currentNum)
                    {
                        maxLength = currentMaxLength > maxLength ? currentMaxLength : maxLength;

                        for (int j = 0; j < currentMaxLength; ++j)
                        {
                            maxCounts.Add(currentNums[j], currentMaxLength);
                        }

                        break;
                    }
                    else
                    {
                        currentNums[currentMaxLength] = currentNum;
                        currentNum = nums[currentNum];
                        ++currentMaxLength;
                    }
                }
            }

            return maxLength;
        }
    }
}
