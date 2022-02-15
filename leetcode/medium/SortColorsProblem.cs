using System;

namespace algo_practice_csharp.leetcode.medium
{
    public class SortColorsProblem
    {
        private void Main(string[] args)
        {
            SortColorsProblem obj = new SortColorsProblem();

            int[] nums1 = { 2, 0, 2, 0, 2, 1, 1, 0 };
            obj.SortColors(nums1);
            Console.WriteLine(string.Join(", ", nums1));

            int[] nums2 = { 2, 0, 2, 1, 2, 1, 1, 0 };
            obj.SortColors(nums2);
            Console.WriteLine(string.Join(", ", nums2));

            int[] nums3 = { 2, 0, 2, 1, 1, 0 };
            obj.SortColors(nums3);
            Console.WriteLine(string.Join(", ", nums3));

            int[] nums11 = { 2, 0, 1 };
            obj.SortColors(nums11);
            Console.WriteLine(string.Join(", ", nums11));

            int[] nums12 = { 1, 1, 2 };
            obj.SortColors(nums12);
            Console.WriteLine(string.Join(", ", nums12));

            int[] nums13 = { 0, 1, 2 };
            obj.SortColors(nums13);
            Console.WriteLine(string.Join(", ", nums13));

            int[] nums21 = { 0 };
            obj.SortColors(nums21);
            Console.WriteLine(string.Join(", ", nums21));

            int[] nums22 = { 1 };
            obj.SortColors(nums22);
            Console.WriteLine(string.Join(", ", nums22));

            int[] nums23 = { 2 };
            obj.SortColors(nums23);
            Console.WriteLine(string.Join(", ", nums23));

            int[] nums31 = { 0, 0 };
            obj.SortColors(nums31);
            Console.WriteLine(string.Join(", ", nums31));

            int[] nums32 = { 1, 1 };
            obj.SortColors(nums32);
            Console.WriteLine(string.Join(", ", nums32));

            int[] nums33 = { 2, 2 };
            obj.SortColors(nums33);
            Console.WriteLine(string.Join(", ", nums33));

            int[] nums41 = { 0, 0, 0 };
            obj.SortColors(nums41);
            Console.WriteLine(string.Join(", ", nums41));

            int[] nums42 = { 1, 1, 1 };
            obj.SortColors(nums42);
            Console.WriteLine(string.Join(", ", nums42));

            int[] nums43 = { 2, 2, 2 };
            obj.SortColors(nums43);
            Console.WriteLine(string.Join(", ", nums43));

            int[] nums51 = { 1, 1, 0 };
            obj.SortColors(nums51);
            Console.WriteLine(string.Join(", ", nums51));

            int[] nums52 = { 0, 2, 1 };
            obj.SortColors(nums52);
            Console.WriteLine(string.Join(", ", nums52));

            int[] nums53 = { 1, 2, 0 };
            obj.SortColors(nums53);
            Console.WriteLine(string.Join(", ", nums53));

            int[] nums61 = { 2, 0 };
            obj.SortColors(nums61);
            Console.WriteLine(string.Join(", ", nums61));

            int[] nums62 = { 2, 1 };
            obj.SortColors(nums62);
            Console.WriteLine(string.Join(", ", nums62));
        }

        public void SortColors(int[] nums)
        {
            int b = 0, c = 0, e = nums.Length - 1;

            while (e >= c)
            {
                if (nums[c] == 0)
                {
                    int temp = nums[b];
                    nums[b] = nums[c];
                    nums[c] = temp;
                    ++b;
                    ++c;
                }
                else if (nums[c] == 2)
                {
                    int temp = nums[e];
                    nums[e] = nums[c];
                    nums[c] = temp;
                    --e;
                }
                else
                {
                    ++c;
                }
            }
        }
    }
}
