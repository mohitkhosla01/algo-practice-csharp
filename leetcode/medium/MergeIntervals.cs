using System;
using System.Collections.Generic;

namespace algo_practice_csharp.leetcode.medium
{
    public class MergeIntervals
    {
        private void Main(string[] args)
        {
            MergeIntervals obj = new MergeIntervals();

            int[][] intervals1 = new int[][] {
                new int[] { 6, 9 },
                new int[] { 1, 4 },
                new int[] { 9, 10 },
                new int[] { 2, 5 }
            };
            int[][] newIntervals1 = obj.Merge(intervals1);
            for (int i = 0; i < newIntervals1.Length; ++i)
            {
                Console.WriteLine(newIntervals1[i][0] + ", " + newIntervals1[i][1]);
            }
            Console.WriteLine();

            int[][] intervals2 = new int[][] {
                new int[] { 1, 3 },
                new int[] { 2, 6 },
                new int[] { 8, 10 },
                new int[] { 15, 18 }
            };
            int[][] newIntervals2 = obj.Merge(intervals2);
            for (int i = 0; i < newIntervals2.Length; ++i)
            {
                Console.WriteLine(newIntervals2[i][0] + ", " + newIntervals2[i][1]);
            }
            Console.WriteLine();

            int[][] intervals3 = new int[][] {
                new int[] { 1, 4 },
                new int[] { 4, 5 }
            };
            int[][] newIntervals3 = obj.Merge(intervals3);
            for (int i = 0; i < newIntervals3.Length; ++i)
            {
                Console.WriteLine(newIntervals3[i][0] + ", " + newIntervals3[i][1]);
            }
            Console.WriteLine();

            int[][] intervals4 = new int[][] {
                new int[] { 1, 3 }
            };
            int[][] newIntervals4 = obj.Merge(intervals4);
            for (int i = 0; i < newIntervals4.Length; ++i)
            {
                Console.WriteLine(newIntervals4[i][0] + ", " + newIntervals4[i][1]);
            }
            Console.WriteLine();

            int[][] intervals5 = new int[][] {
                new int[] { 1, 4 },
                new int[] { 1, 3 }
            };
            int[][] newIntervals5 = obj.Merge(intervals5);
            for (int i = 0; i < newIntervals5.Length; ++i)
            {
                Console.WriteLine(newIntervals5[i][0] + ", " + newIntervals5[i][1]);
            }
            Console.WriteLine();

            int[][] intervals6 = new int[][] {
                new int[] { 0, 2 },
                new int[] { 1, 7 },
                new int[] { 2, 11 },
                new int[] { 3, 15 }
            };
            int[][] newIntervals6 = obj.Merge(intervals6);
            for (int i = 0; i < newIntervals6.Length; ++i)
            {
                Console.WriteLine(newIntervals6[i][0] + ", " + newIntervals6[i][1]);
            }
            Console.WriteLine();
        }

        public int[][] Merge(int[][] intervals)
        {
            if (intervals == null || intervals.Length == 0)
            {
                return null;
            }

            Sort(intervals);

            List<int[]> newIntervals = new List<int[]>();
            newIntervals.Add(intervals[0]);
            int index = 0;

            if(intervals.Length >= 2)
            {      
                for (int i=1; i<intervals.Length; ++i)
                {
                    if(intervals[i][0] >= newIntervals[index][0] && intervals[i][0] <= newIntervals[index][1])
                    {
                        newIntervals[index][0] = newIntervals[index][0] > intervals[i][0] ? intervals[i][0] : newIntervals[index][0];
                        newIntervals[index][1] = newIntervals[index][1] < intervals[i][1] ? intervals[i][1] : newIntervals[index][1];
                    }
                    else
                    {
                        int[] newInterval = { intervals[i][0], intervals[i][1] };
                        newIntervals.Add(newInterval);
                        ++index;
                    }
                }
            }

            return newIntervals.ToArray();
        }

        public void Sort(int[][] arr)
        {
            if(arr != null && arr.Length >= 2)
            {
                for (int i=0; i<arr.Length; ++i)
                {
                    for(int j=i+1; j<arr.Length; ++j)
                    {
                        if(arr[i][0] > arr[j][0])
                        {
                            int tempStart = arr[i][0];
                            int tempEnd = arr[i][1];
                            arr[i][0] = arr[j][0];
                            arr[i][1] = arr[j][1];
                            arr[j][0] = tempStart;
                            arr[j][1] = tempEnd;
                        }
                    }
                }
            }
        }
    }
}
