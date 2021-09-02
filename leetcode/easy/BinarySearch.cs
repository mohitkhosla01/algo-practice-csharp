using System;

namespace algo_practice_csharp.leetcode.easy
{
    public class BinarySearch
    {
        private void Main(string[] args)
        {
            BinarySearch binarySearch = new BinarySearch();

            Console.WriteLine("nums0: " + binarySearch.Search(null, 5));

            int[] nums1 = { 1 };
            Console.WriteLine("nums1: " + binarySearch.Search(nums1, 9));

            int[] nums2 = { 1 };
            Console.WriteLine("nums2: " + binarySearch.Search(nums2, 1));

            int[] nums11 = { 5, 8 };
            Console.WriteLine("nums11: " + binarySearch.Search(nums11, 7));

            int[] nums12 = { 5, 8 };
            Console.WriteLine("nums12: " + binarySearch.Search(nums12, 3));

            int[] nums13 = { 5, 8 };
            Console.WriteLine("nums13: " + binarySearch.Search(nums13, 9));

            int[] nums14 = { 5, 8 };
            Console.WriteLine("nums14: " + binarySearch.Search(nums14, 5));

            int[] nums15 = { 5, 8 };
            Console.WriteLine("nums15: " + binarySearch.Search(nums15, 8));

            int[] nums21 = { 5, 9, 12 };
            Console.WriteLine("nums21: " + binarySearch.Search(nums21, 10));

            int[] nums22 = { 5, 9, 12 };
            Console.WriteLine("nums22: " + binarySearch.Search(nums22, 6));

            int[] nums23 = { 5, 9, 12 };
            Console.WriteLine("nums23: " + binarySearch.Search(nums23, 2));

            int[] nums24 = { 5, 9, 12 };
            Console.WriteLine("nums24: " + binarySearch.Search(nums24, 15));

            int[] nums25 = { 5, 9, 12 };
            Console.WriteLine("nums25: " + binarySearch.Search(nums25, 5));

            int[] nums26 = { 5, 9, 12 };
            Console.WriteLine("nums26: " + binarySearch.Search(nums26, 9));

            int[] nums27 = { 5, 9, 12 };
            Console.WriteLine("nums27: " + binarySearch.Search(nums27, 12));

            int[] nums101 = { -1, 0, 3, 5, 9, 12 };
            Console.WriteLine("nums101: " + binarySearch.Search(nums101, 9));

            int[] nums102 = { -1, 0, 3, 5, 9, 12 };
            Console.WriteLine("nums102: " + binarySearch.Search(nums102, 2));
        }

        public int Search(int[] nums, int target)
        {
            if(nums == null || nums.Length == 0)
            {
                return -1;
            }
            else if(nums.Length == 1)
            {
                if(nums[0] == target)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }


            int b = 0, e = nums.Length - 1;
            while(b <= e)
            {
                int mid = (b + e) / 2;
                if(nums[mid] == target)
                {
                    return mid;
                }
                else if(nums[mid] < target)
                {
                    if(mid == nums.Length - 1)
                    {
                        return -1;
                    }

                    b = mid + 1;
                }
                else
                {
                    if (mid == 0)
                    {
                        return -1;
                    }

                    e = mid - 1;
                }
            }

            return -1;
        }
    }
}
