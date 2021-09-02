using System;

namespace algo_practice_csharp.leetcode.easy
{
    public class MoveZerosProblem
    {
        private void Main(string[] args)
        {
            MoveZerosProblem moveZerosProblem = new MoveZerosProblem();

            int[] nums1 = { 0, 1, 0, 3, 12 };
            moveZerosProblem.MoveZeroes(nums1);
            Console.WriteLine(string.Join(",", nums1));

            int[] nums2 = { 0 };
            moveZerosProblem.MoveZeroes(nums2);
            Console.WriteLine(string.Join(",", nums2));

            int[] nums11 = { 1, 11, 21, 31, 0 };
            moveZerosProblem.MoveZeroes(nums11);
            Console.WriteLine(string.Join(",", nums11));

            int[] nums12 = { 1, 11, 21, 0, 31 };
            moveZerosProblem.MoveZeroes(nums12);
            Console.WriteLine(string.Join(",", nums12));

            int[] nums13 = { 1, 11, 0, 21, 31 };
            moveZerosProblem.MoveZeroes(nums13);
            Console.WriteLine(string.Join(",", nums13));

            int[] nums21 = { 1, 2, 5, 6, 10 };
            moveZerosProblem.MoveZeroes(nums21);
            Console.WriteLine(string.Join(",", nums21));
        }

        public void MoveZeroes(int[] nums)
        {
            int index = 0;

            for(int i=0; i<nums.Length; ++i)
            {
                if(nums[i] != 0)
                {
                    nums[index] = nums[i];
                    if(i != index)
                    {
                        nums[i] = 0;
                    }
                    ++index;
                }
            }
        }
    }
}
