using System;
using System.Collections.Generic;

namespace array
{
    public class Display
    {
        public static void Matrix(int[][] matrix) {
            for(int i = 0; i < matrix.Length; ++i) {
                for(int j = 0; j < matrix[i].Length; ++j) {
                    if (j == 0) Console.Write("[ ");
                    if (j != 0) Console.Write(", ");
                    if (matrix[i][j] < 10 ) Console.Write(" ");

                    Console.Write(matrix[i][j]);

                    if (j + 1 == matrix[i].Length) Console.Write(" ]");
                }
                Console.WriteLine();
            }
        }

        public static void Array(int[] arr) {
            for(int i = 0; i < arr.Length; ++i) {
                if (i == 0) Console.Write("[ ");
                if (i != 0) Console.Write(", ");
                Console.Write(arr[i]);
                if (i + 1 == arr.Length) Console.Write(" ]");
            }
        }

        public static void HashSetTriple(HashSet<Tuple<int, int, int>> set) {
            Console.WriteLine($"[ {String.Join(", ", set)} ]");
        }
    }
}