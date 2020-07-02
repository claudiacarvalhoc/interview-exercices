using System;
using System.Collections.Generic;

namespace array
{
    public class CountSubarraysThatSum2K
    {

        /**
Count Subarrays That Sum To K
Given an array of integers arr and an integer value k, return the total amount of unique, contiguous, subarrays that sum to k in arr.

Example 1:
Input: [1, 0, -1, 1] k = 0
Output: 4
Explanation: 4 subarrays sum up to 0

                       i j
[1, 0, -1, 1] [1,1]
[1, 0, -1, 1] [0,2]
[1, 0, -1, 1] [1,3]
[1, 0, -1, 1] [2,3]

Example 2:
Input: [3, 7, -4, -2, 1, 5] k = 3
Output: 2
Explanation: 2 subarrays sum up to 3

                              i j
[3, 7, -4, -2, 1, 5] [0,0]
[3, 7, -4, -2, 1, 5] [1,2]
*/
        public static void Run()
        {
            int[] arr = new int[] { 1, 0, -1, 1 };
            int count = countSubarrays(arr, 0);
            Print(arr, count);

            arr = new int[] { 3, 7, -4, -2, 1, 5 };
            count = countSubarrays(arr, 3);
            Print(arr, count);
        }

        public static int countSubarrays(int[] arr, int k)
        {
            int[] sums = new int[arr.Length];
            sums[0] = arr[0];

            for (int i = 1; i < arr.Length; i++) {
                sums[i] = sums[i - 1] + arr[i];
            }

            int count = 0;
            for (int start = 0; start < arr.Length; start++) {
                for (int end = start; end < arr.Length; end++) {
                    int tempSum = sums[end];

                    if (start != 0)
                    {
                        tempSum -= sums[start - 1];
                    }

                    if (tempSum == k)
                    {
                        count += 1;
                    }
                }
            }

            return count;
        }

        public static void Print(int[] arr, int count) {
            Console.WriteLine("Input:");
            Display.Array(arr);
            Console.WriteLine();
            Console.WriteLine($"Output: {count}");
        }
    }
}