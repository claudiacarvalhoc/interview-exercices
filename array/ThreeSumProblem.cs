using System;
using System.Collections.Generic;

namespace array
{
    public class ThreeSumProblem
    {
        public static void Run() {
            int[] arr = new int[] { -3, -1, 1, 0, 2, 10, -2, 8 };
            HashSet<Tuple<int, int, int>> result = Solution(arr);
            PrintResult(arr, result);

            arr = new int[] { -5, 3, 2, 0, 1, -1, -5, 3, 2 };
            result = Solution(arr);
            PrintResult(arr, result);
        }

        public static HashSet<Tuple<int, int, int>> Solution(int[] arr) {
            // sort the array
            Array.Sort(arr);
            HashSet<Tuple<int, int, int>> set = new HashSet<Tuple<int, int, int>>(); 

            for (int i = 0; i < arr.Length - 2; ++i) {
                FindTriple(i, arr, set);
            }

            return set;
        }

        public static void FindTriple(int rootIndex, int[] arr, HashSet<Tuple<int, int, int>> set) {
            int left = rootIndex + 1;
            int right = arr.Length - 1;

            while (left < right) {
                int sum = arr[rootIndex] + arr[left] + arr[right];
                // Console.WriteLine($"left :: {left} - right :: {right} - sum :: {sum} ");
                if (sum == 0) {
                    set.Add(new Tuple<int, int, int>(arr[rootIndex], arr[left], arr[right]));
                    break;
                } else if (sum < 0) {
                    ++left;
                } else {
                    --right;
                }
            }
        }

        private static void PrintResult(int[] arr, HashSet<Tuple<int, int, int>> result) {
            Console.Write("Input: ");
            Display.Array(arr);
            Console.WriteLine();
            Console.Write("Result: ");
            Display.HashSetTriple(result);
            Console.WriteLine();
        }
    }
}