using System;

namespace algo_practice_csharp.leetcode.medium
{
    public class RotateArray
    {
        private void Main(string[] args)
        {
            RotateArray rotateArray = new RotateArray();

            int[] nums1 = { 1, 2, 3, 4, 5, 6, 7 };
            rotateArray.Rotate(nums1, 3);
            Console.WriteLine(string.Join(",", nums1));

            int[] nums2 = { -1, -100, 3, 99 };
            rotateArray.Rotate(nums2, 2);
            Console.WriteLine(string.Join(",", nums2));

            int[] nums11 = { 1, 2, 3, 4, 5, 6, 7 };
            rotateArray.Rotate(nums11, 0);
            Console.WriteLine(string.Join(",", nums11));

            int[] nums12 = { 1, 2, 3, 4, 5, 6, 7 };
            rotateArray.Rotate(nums12, 1);
            Console.WriteLine(string.Join(",", nums12));
        }

        public void Rotate(int[] nums, int k)
        {
            k %= nums.Length;

            int[] newNums = new int[nums.Length];

            for (int i = 0; i < nums.Length; ++i)
            {
                newNums[i] = nums[i];
            }

            for (int i = 0; i < nums.Length; ++i)
            {
                nums[(i+k)%nums.Length] = newNums[i];
            }
        }
    }
}
