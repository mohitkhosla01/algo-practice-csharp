using System;

namespace algo_practice_csharp.leetcode.easy
{
    public class SignOfProductOfArray
    {
        private void Main(string[] args)
        {
            SignOfProductOfArray obj = new SignOfProductOfArray();

            int[] arr1 = { -1, -2, -3, -4, 3, 2, 1 };
            Console.WriteLine(obj.ArraySign(arr1));

            int[] arr2 = { 1, 5, 0, 2, -3 };
            Console.WriteLine(obj.ArraySign(arr2));

            int[] arr3 = { -1, 1, -1, 1, -1 };
            Console.WriteLine(obj.ArraySign(arr3));

            int[] arr4 = { 7, 36, 96, 70, 85, 23, 5, 18, 4, 12, 89, 92, 9, 30, 53, 14, 96, 32, 13, 43, 37, 60, 75, 7, 83, 68, 20, 8, -24, -80, -27, -92, -96, -20, -16, -52, -49, -38};
            Console.WriteLine(obj.ArraySign(arr4));
        }

        public int ArraySign(int[] nums)
        {
            bool negativeFlag = false;

            for(int i=0; i<nums.Length; ++i)
            {
                if(nums[i] == 0)
                {
                    return 0;
                }
                else if(nums[i] < 0)
                {
                    negativeFlag = negativeFlag == false ? true : false;
                }
            }

            return negativeFlag == false ? 1 : -1;
        }
    }
}
