using System;

namespace algo_practice_csharp.leetcode.easy
{
    public class SearchInsertPosition
    {
        private void Main(string[] args)
        {
            SearchInsertPosition searchInsertPosition = new SearchInsertPosition();

            int[] nums1 = { 1, 3, 5, 6 };
            Console.WriteLine(searchInsertPosition.SearchInsert(nums1, 5));

            int[] nums2 = { 1, 3, 5, 6 };
            Console.WriteLine(searchInsertPosition.SearchInsert(nums2, 2));

            int[] nums3 = { 1, 3, 5, 6 };
            Console.WriteLine(searchInsertPosition.SearchInsert(nums3, 7));

            int[] nums4 = { 1, 3, 5, 6 };
            Console.WriteLine(searchInsertPosition.SearchInsert(nums4, 0));

            int[] nums5 = { 1 };
            Console.WriteLine(searchInsertPosition.SearchInsert(nums5, 0));

            int[] nums11 = { 1 };
            Console.WriteLine(searchInsertPosition.SearchInsert(nums11, 1));
            Console.WriteLine(searchInsertPosition.SearchInsert(nums11, 2));

            int[] nums21 = { 1, 11, 21, 31, 41 };
            Console.WriteLine(searchInsertPosition.SearchInsert(nums21, 0));
            Console.WriteLine(searchInsertPosition.SearchInsert(nums21, 10));
            Console.WriteLine(searchInsertPosition.SearchInsert(nums21, 20));
            Console.WriteLine(searchInsertPosition.SearchInsert(nums21, 30));
            Console.WriteLine(searchInsertPosition.SearchInsert(nums21, 40));
            Console.WriteLine(searchInsertPosition.SearchInsert(nums21, 50));
        }

        public int SearchInsert(int[] nums, int target)
        {
            int b = 0, e = nums.Length - 1;
            int mid = -1;
            
            while(b <= e)
            {
                mid = b + (e - b) / 2;
                
                if(nums[mid] == target)
                {
                    return mid;
                }
                else if(nums[mid] > target)
                {
                    e = mid - 1;
                }
                else
                {
                    b = mid + 1;
                }
            }

            return nums[mid] > target ? mid : mid + 1;
        }
    }
}
