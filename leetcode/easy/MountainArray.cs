using System;
namespace algo_practice_csharp.leetcode.easy
{
    public class MountainArray
    {
        private void Main(string[] args)
        {
            MountainArray obj = new MountainArray();

            // int[] arr = null;
            // int[] arr = { };
            // int[] arr = { 0 };
            // int[] arr = { 1 };
            // int[] arr = { 2, 1 };
            // int[] arr = { 3, 5, 5 };
            int[] arr = { 0, 3, 2, 1 };

            Console.WriteLine(obj.ValidMountainArray(arr));
        }

        public bool ValidMountainArray(int[] arr)
        {
            if(arr == null || arr.Length == 0)
            {
                return false;
            }

            int Li = IndexOfLargestNumber(arr);

            if(Li == -1 || Li == 0 || Li == arr.Length - 1)
            {
                return false;
            }

            for(int i = Li - 1; i >= 0; --i)
            {
                if(arr[i] >= arr[i + 1])
                {
                    return false;
                }
            }

            for (int i = Li + 1; i < arr.Length; ++i)
            {
                if (arr[i] >= arr[i - 1])
                {
                    return false;
                }
            }

            return true;
        }

        public int IndexOfLargestNumber(int[] arr)
        {
            int L = arr[0], Li = 0;

            for (int i = 1; i < arr.Length; ++i) {
                if(arr[i] == L)
                {
                    return -1;
                }
                else if (arr[i] > L)
                {
                    L = arr[i];
                    Li = i;
                }
            }

            return Li;
        }
    }
}