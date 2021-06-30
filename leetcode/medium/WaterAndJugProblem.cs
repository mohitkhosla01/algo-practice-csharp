using System;

namespace algo_practice_csharp.leetcode.medium
{
    public class WaterAndJugProblem
    {
        private void Main(string[] args)
        {
            /*
             * Could not solve this problem.
             * Need to retry.
             */

            WaterAndJugProblem obj = new WaterAndJugProblem();

            Console.WriteLine("3, 5, 4: " + obj.CanMeasureWater(3, 5, 4));
            Console.WriteLine("2, 6, 5: " + obj.CanMeasureWater(2, 6, 5));

            Console.WriteLine("0, 0, 0: " + obj.CanMeasureWater(0, 0, 0));
            Console.WriteLine("1, 0, 0: " + obj.CanMeasureWater(1, 0, 0));
            Console.WriteLine("0, 1, 0: " + obj.CanMeasureWater(0, 1, 0));
            Console.WriteLine("0, 1, 1: " + obj.CanMeasureWater(0, 1, 1));
            Console.WriteLine("1, 1, 0: " + obj.CanMeasureWater(1, 1, 0));
            Console.WriteLine("0, 2, 2: " + obj.CanMeasureWater(0, 2, 2));
            Console.WriteLine("1, 2, 3: " + obj.CanMeasureWater(1, 2, 3));
            Console.WriteLine("3, 7, 4: " + obj.CanMeasureWater(3, 7, 4));
            Console.WriteLine("3, 7, 5: " + obj.CanMeasureWater(3, 7, 5));
            Console.WriteLine("3, 7, 6: " + obj.CanMeasureWater(3, 7, 6));
            Console.WriteLine("4, 8, 5: " + obj.CanMeasureWater(4, 8, 5));
            Console.WriteLine("4, 8, 6: " + obj.CanMeasureWater(4, 8, 6));
            Console.WriteLine("5, 8, 6: " + obj.CanMeasureWater(5, 8, 6));
            Console.WriteLine("4, 6, 8: " + obj.CanMeasureWater(4, 6, 8));
            Console.WriteLine("8, 7, 9: " + obj.CanMeasureWater(8, 7, 9));
            Console.WriteLine("8, 7, 10: " + obj.CanMeasureWater(8, 7, 10));

            Console.WriteLine("1, 1, 12: " + obj.CanMeasureWater(1, 1, 12));
            Console.WriteLine("3, 5, 12: " + obj.CanMeasureWater(3, 5, 12));
        }

        public bool CanMeasureWater(int x, int y, int z)
        {
            if (x == z || y == z || (x + y) == z || z == 0)
            {
                return true;
            }
            else if (x == y && x != z)
            {
                return false;
            }
            if (x == 0)
            {
                return y == z ? true : false;
            }
            else if (y == 0)
            {
                return x == z ? true : false;
            }

            int xtemp = x, ytemp = y;
            x = Math.Min(xtemp, ytemp);
            y = Math.Max(xtemp, ytemp);

            int x1 = 0, y1 = y;

            while(x1 != x && y1 != 0)
            {
                y1 = y1 - (x - x1);
                if(y1 == z)
                {
                    return true;
                }
                else if (y1 == x)
                {
                    return false;
                }
                else if(y1 < x)
                {
                    x1 = y1;
                    y1 = y;

                    if(z > y && (z == (x1 + y1)))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
