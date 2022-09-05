using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAP
{
    public static class ArraysMaths
    {

        //42. Trapping Rain Water
        //https://leetcode.com/problems/trapping-rain-water/

        public static int Trap(int[] height)
        {
            int arrayLen = height.Length;
            if (height == null || arrayLen == 0)
            {
                return 0;
            }

            int start = 0, waterTrap = 0, maxLeft = 0, maxRight = 0;
            int end = arrayLen - 1;
            while (start < end)
            {
                if (height[start] < height[end])
                {
                    if (height[start] >= maxLeft)
                    {
                        maxLeft = height[start];
                    }
                    else
                    {
                        waterTrap += maxLeft - height[start];
                    }
                    start++;
                }
                else
                {
                    if (height[end] >= maxRight)
                    {
                        maxRight = height[end];
                    }
                    else
                    {
                        waterTrap += maxRight - height[end];
                    }
                    end--;
                }
            }

            return waterTrap;
        }
        public static int Trap2(int[] height)
        {
            int arrayLen = height.Length;
            if (height == null || arrayLen == 0)
            {
                return 0;
            }
            int end = arrayLen - 1;
            int start = 0, waterTrapped = 0, maxLeft = height[start], maxRight = height[end];
            
            while (start < end)
            {
                if (maxLeft<maxRight)
                {
                   start++;
                    maxLeft=Math.Max(maxLeft, height[start]);
                    waterTrapped+=maxLeft- height[start];

                }
                else
                {
                    end--;
                    maxRight=Math.Max(maxRight, height[end]);
                    waterTrapped+=maxRight- height[end];
                }
            }

            return waterTrapped;
        }
    }
}
