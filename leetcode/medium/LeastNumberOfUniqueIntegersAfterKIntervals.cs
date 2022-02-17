using System;
using System.Collections.Generic;

namespace algo_practice_csharp.leetcode.medium
{
    public class LeastNumberOfUniqueIntegersAfterKIntervals
    {
        private void Main(string[] args)
        {
            LeastNumberOfUniqueIntegersAfterKIntervals obj = new LeastNumberOfUniqueIntegersAfterKIntervals();

            int[] nums1 = { 5, 5, 4 };
            int k1 = 1;
            Console.WriteLine(obj.FindLeastNumOfUniqueInts(nums1, k1));

            int[] nums2 = { 4, 3, 1, 1, 3, 3, 2 };
            int k2 = 3;
            Console.WriteLine(obj.FindLeastNumOfUniqueInts(nums2, k2));

            int[] nums11 = { 4, 3, 1, 1, 3, 3, 2 };
            int k11 = 4;
            Console.WriteLine(obj.FindLeastNumOfUniqueInts(nums11, k11));

            int[] nums12 = { 4, 3, 1, 1, 3, 3, 2 };
            int k12 = 5;
            Console.WriteLine(obj.FindLeastNumOfUniqueInts(nums12, k12));

            int[] nums13 = { 4, 3, 1, 1, 3, 3, 2 };
            int k13 = 2;
            Console.WriteLine(obj.FindLeastNumOfUniqueInts(nums13, k13));

            int[] nums14 = { 4, 3, 1, 1, 3, 3, 2, 2 };
            int k14 = 2;
            Console.WriteLine(obj.FindLeastNumOfUniqueInts(nums14, k14));
        }

        public int FindLeastNumOfUniqueInts(int[] arr, int k)
        {
            Dictionary<int, int> values = new Dictionary<int, int>();

            for(int i=0; i<arr.Length; ++i)
            {
                if(values.ContainsKey(arr[i]))
                {
                    ++values[arr[i]]; 
                }
                else
                {
                    values.Add(arr[i], 1);
                }
            }

            int[] freq = new int[values.Count];
            int freqC = 0;

            foreach(KeyValuePair<int, int> valuesEntry in values) {
                freq[freqC++] = valuesEntry.Value;
            }

            Array.Sort(freq);
            for(int i=0; i<freq.Length; ++i)
            {
                k -= freq[i];
                if(k == 0)
                {
                    return freq.Length - i - 1;
                }
                else if(k < 0)
                {
                    return freq.Length - i;
                }
            }

            return 0;
        }
    }
}
