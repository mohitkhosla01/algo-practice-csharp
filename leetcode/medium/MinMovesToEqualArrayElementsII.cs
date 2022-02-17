using System;

namespace algo_practice_csharp.leetcode.medium
{
    public class MinMovesToEqualArrayElementsII
    {
        private void Main(string[] args)
        {
            MinMovesToEqualArrayElementsII obj = new MinMovesToEqualArrayElementsII();

            int[] nums1 = { 1, 2, 3 };
            Console.WriteLine(obj.MinMoves2(nums1));

            int[] nums2 = { 1, 10, 2, 9 };
            Console.WriteLine(obj.MinMoves2(nums2));

            int[] nums3 = { 1, 0, 0, 8, 6 };
            Console.WriteLine(obj.MinMoves2(nums3));

            int[] nums11 = { 1 };
            Console.WriteLine(obj.MinMoves2(nums11));

            int[] nums12 = { 1, 1 };
            Console.WriteLine(obj.MinMoves2(nums12));

            int[] nums13 = { 1, 1, 1 };
            Console.WriteLine(obj.MinMoves2(nums13));
        }

        public int MinMoves2(int[] nums)
        {
            int c = 0;
            int begin = 0, end = nums.Length - 1;
            Array.Sort(nums);

            while (begin < end)
            {
                c += Math.Abs(nums[end] - nums[begin]);
                ++begin;
                --end;
            }
            
            return c;
        }
    }
}
