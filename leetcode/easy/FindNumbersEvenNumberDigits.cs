using System;
namespace algo_practice_csharp.leetcode.easy
{
    public class FindNumbersEvenNumberDigits
    {
        private void Main(string[] args)
        {
            FindNumbersEvenNumberDigits obj = new FindNumbersEvenNumberDigits();

            // int[] nums = null;
            // int[] nums = { };
            // int[] nums = { 0 };
            // int[] nums = { 0, 4 };
            // int[] nums = { 1, 4 };
            // int[] nums = { 0, 0, 1 };
            // int[] nums = { 0, 0, 5 };
            // int[] nums = { 1 };
            int[] nums = { 3, 12, 14, 22, 26 };
            // int[] nums = { 12, 345, 2, 6, 7896 };
            // int[] nums = { 555, 901, 482, 1771 };

            int maxOnes = obj.FindNumbers(nums);
            Console.WriteLine(maxOnes);
        }

        public int FindNumbers(int[] nums)
        {
            if(nums == null)
            {
                return 0;
            }

            int evenNums = 0;

            foreach(int num in nums)
            {
                if(num != 0)
                {
                    int tempNum = num;
                    int n = 0;

                    while (tempNum != 0)
                    {
                        tempNum /= 10;
                        ++n;
                    }

                    if (n % 2 == 0)
                    {
                        ++evenNums;
                    }
                }
            }

            return evenNums;
        }
    }
}
