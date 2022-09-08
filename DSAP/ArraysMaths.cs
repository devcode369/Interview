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
            int[] arr3 = new int[arr1Len];
            int[] arr4 = new int[arr1Len];
            int[] arr5 = new int[arr1Len];
            int[] arr6 = new int[arr1Len];
            int[] arr7 = new int[4];

            if (arr1 == null || arr2 == null || arr1Len == 0 || arr2Len == 0 || arr1Len != arr2Len)
            {
                return 0;
            }

            for (int i = 0; i < arr1.Length; i++)
            {
                arr3.SetValue((i + arr1[i] + arr2[i]), i);
                arr4.SetValue((i - arr1[i] + arr2[i]), i);
                arr5.SetValue((i + arr1[i] - arr2[i]), i);
                arr6.SetValue((i - arr1[i] - arr2[i]), i);
            }

            arr7.SetValue(arr3.Max() - arr3.Min(), 0);
            arr7.SetValue(arr4.Max() - arr4.Min(), 1);
            arr7.SetValue(arr5.Max() - arr5.Min(), 2);
            arr7.SetValue(arr6.Max() - arr6.Min(), 3);

            return arr7.Max();

        }

        //164. Maximum Gap
        //https://leetcode.com/problems/maximum-gap/submissions/
        //https://leetcode.com/problems/maximum-gap/discuss/50643/bucket-sort-JAVA-solution-with-explanation-O(N)-time-and-space
        //https://leetcode.com/problems/maximum-gap/discuss/726951/Java-meaningful-Variable-names-(radix-sort-%2B-bucket-sort)
        public static int MaximumGap(int[] nums)
        {
            if (nums == null || nums.Length == 0 || nums.Length < 2)
            {
                return 0;
            }

            int min = nums.Min(), max = nums.Max();

            int n = nums.Length;
            int bucketSize = (max - min) / (n - 1);
            if (bucketSize == 0) bucketSize++;
            int totalBuckets = (max - min) / bucketSize + 1;

            int[] minBucket = new int[totalBuckets];
            int[] maxBucket = new int[totalBuckets];
          
            minBucket= Enumerable.Repeat(int.MaxValue, totalBuckets).ToArray();          

            for (int i = 0; i < n; i++)
            { 
                int index = (nums[i] - min) / bucketSize;
                minBucket[index] = Math.Min(minBucket[index], nums[i]);
                maxBucket[index] = Math.Max(maxBucket[index], nums[i]);
            }
            int prevMax = maxBucket[0], result = 0;
            for (int i = 1; i < totalBuckets; i++)
            {
                if (minBucket[i] == int.MaxValue) continue;
                result = Math.Max(result, minBucket[i] - prevMax);
                prevMax = maxBucket[i];
            }
            return result;
        }

        //59. Spiral Matrix II
        //https://leetcode.com/problems/spiral-matrix-ii/
        //https://leetcode.com/problems/spiral-matrix-ii/discuss/1941518/c-or-easy-to-understand-or-with-comments
        public static int[][] GenerateMatrix(int n)
        {

            int[][] matrix = new int[n][];
            for (int i = 0; i < n; i++)
                matrix[i] = new int[n];

            int top = 0, bottom = n - 1, left = 0, right = n - 1;

            int count = 1;
            while (true)
            {           
                for (int i = left; i <= right; i++)
                    matrix[top][i] = count++;

                top++;
                if (top > bottom)
                    break;             
                for (int i = top; i <= bottom; i++)
                    matrix[i][right] = count++;
                right--; 
                if (left > right)
                    break;           
                for (int i = right; i >= left; i--)
                    matrix[bottom][i] = count++;
                bottom--;
            
                for (int i = bottom; i >= top; i--)
                    matrix[i][left] = count++;

                left++;

            }

            return matrix;
        }


        public static IList<string> FizzBuzz(int n)
        {
            List<string> list = new List<string>();
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= n; i++)
            {
                bool divBy3 = i % 3 == 0;
                bool divBy5 = i % 5 == 0;
                if(divBy3)
                {
                    sb.Append("Fizz");
                }
                if (divBy5)
                {
                    sb.Append("Buzz");
                }
                if (sb.Length==0)
                {
                    sb.Append(i.ToString());
                }
                list.Add(sb.ToString());
                sb.Clear();
            }
            return list;
        }


        public static int DiagonalSum(int[][] mat)
        {
            int result=0;
            int len=mat.Length;
            for (int i = 0; i < len; i++)
            {
                result += mat[i][i];
                result += mat[len - 1 - i][i];
            }
            return len % 2 == 0 ? result : result - mat[len / 2][len / 2];
        }

        //https://leetcode.com/problems/concatenation-of-array/submissions/
        public static int[] GetConcatenation(int[] nums)
        {
            if(nums == null||nums.Length==0)
            {
                return new int[0];
            }

            return  nums.Concat(nums).ToArray();
        }

        public static int MostWordsFound(string[] sentences)
        {
            int result = 0;
            if(sentences == null||sentences.Length==0)
            {
                return result;
            }

            foreach (var item in sentences)
            {
               result =Math.Max(result,item.Split(' ').Length);
            }
            return result;
        }
        //https://leetcode.com/problems/maximum-subarray/discuss/20211/Accepted-O(n)-solution-in-java

        public static int MaxSubArray(int[] nums)
        {
            int currentMax = nums[0], currentMin = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                currentMin = Math.Max(currentMin + nums[i], nums[i]);
                currentMax = Math.Max(currentMax, currentMin);
            }
            return currentMax;
        }
    }
}
