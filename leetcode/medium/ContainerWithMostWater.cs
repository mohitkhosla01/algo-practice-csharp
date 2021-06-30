using System;

namespace algo_practice_csharp.leetcode.medium
{
    public class ContainerWithMostWater
    {
        private void Main(string[] args)
        {
            ContainerWithMostWater obj = new ContainerWithMostWater();

            // int[] height = null;
            // int[] height = { };
            // int[] height = { 5 };
            // int[] height = { 5, 2 };
            // int[] height = { 1, 4 };
            // int[] height = { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };

            // int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            // int[] height = { 1, 1 };
            // int[] height = { 4, 3, 2, 1, 4 };
            int[] height = { 1, 2, 1 };

            Console.WriteLine(obj.MaxArea(height));
        }
        public int MaxArea(int[] height)
        {
            if(height == null || height.Length < 2)
            {
                return 0;
            }

            int maxArea = 0;
            int begin = 0, end = height.Length - 1;

            while (begin < end)
            {
                int area = Math.Min(height[begin], height[end]) * (end - begin);
                maxArea = area > maxArea ? area : maxArea;

                if (height[begin] < height[end])
                {
                    ++begin;
                }
                else
                {
                    --end;
                }
            }

            return maxArea;
        }
    }
}
