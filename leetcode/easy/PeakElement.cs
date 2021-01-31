using System;
namespace algo_practice_csharp.leetcode.easy
{
    public class PeakElement
    {
        private void Main(string[] args)
        {
            PeakElement obj = new PeakElement();

            // int[] nums = null;
            // int[] nums = { };
            // int[] nums = { 0 };
            // int[] nums = { 1 };
            // int[] nums = { 1, 2 };
            // int[] nums = { 2, 1 };
            // int[] nums = { 3, 1, 2 };
            // int[] nums = { 3, 5, 6 };
            // int[] nums = { 0, 3, 2, 1 };
            // int[] nums = { 1, 2, 3, 1 };
            int[] nums = { 1, 2, 1, 3, 5, 6, 4 };

            Console.WriteLine(obj.FindPeakElement(nums));
        }

        public int FindPeakElement(int[] nums)
        {
            if(nums == null || nums.Length == 0)
            {
                return -1;
            }
            else if(nums.Length == 1)
            {
                return 0;
            }

            int begin = 0, end = nums.Length - 1;
            while(begin <= end)
            {
                int mid = (begin + end) / 2;

                if(mid == 0)
                {
                    if(nums[mid] < nums[mid + 1])
                    {
                        begin = mid + 1;
                    }
                    else
                    {
                        return mid;
                    }
                }

                else if (mid == nums.Length - 1)
                {
                    if (nums[mid - 1] > nums[mid])
                    {
                        end = mid - 1;
                    }
                    else
                    {
                        return mid;
                    }
                }

                else
                {
                    if (nums[mid - 1] < nums[mid] && nums[mid] > nums[mid + 1])
                    {
                        return mid;
                    }
                    else if (nums[mid - 1] < nums[mid])
                    {
                        begin = mid + 1;
                    }
                    else if (nums[mid - 1] > nums[mid])
                    {
                        end = mid - 1;
                    }
                }
            }

            return -1;
        }
    }
}
