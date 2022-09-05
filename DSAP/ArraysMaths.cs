using System;
using System.Collections;
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
                if (maxLeft < maxRight)
                {
                    start++;
                    maxLeft = Math.Max(maxLeft, height[start]);
                    waterTrapped += maxLeft - height[start];

                }
                else
                {
                    end--;
                    maxRight = Math.Max(maxRight, height[end]);
                    waterTrapped += maxRight - height[end];
                }
            }

            return waterTrapped;
        }


        //1131. Maximum of Absolute Value Expression
        //https://leetcode.com/problems/maximum-of-absolute-value-expression/
        public static int MaxAbsValExpr(int[] arr1, int[] arr2)
        {
            int arr1Len = arr1.Length;
            int arr2Len = arr2.Length;
            int result = 0;
            int[] arr3 = new int[arr1Len];
            int[] arr4 = new int[arr1Len];
            int[] arr5 = new int[arr1Len];
            int[] arr6 = new int[arr1Len];
            int[] arr7 = new int[4];

            if (arr1 == null || arr2 == null || arr1Len == 0 || arr2Len == 0 || arr1Len != arr2Len)
            {
                return result;
            }

            for (int i = 0; i < arr1.Length; i++)
            {
                arr3.SetValue((i + arr1[i] + arr2[i]), i);
                arr4.SetValue((i - arr1[i] + arr2[i]), i);
                arr5.SetValue((i + arr1[i] - arr2[i]), i);
                arr6.SetValue((i - arr1[i] - arr2[i]), i);
            }

            arr7.SetValue(Math.Max(result, arr3.Max() - arr3.Min()), 0);
            arr7.SetValue(Math.Max(result, arr4.Max() - arr4.Min()), 1);
            arr7.SetValue(Math.Max(result, arr5.Max() - arr5.Min()), 2);
            arr7.SetValue(Math.Max(result, arr6.Max() - arr6.Min()), 3);

            return arr7.Max();

        }

    }
}
