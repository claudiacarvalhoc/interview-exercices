using System;
using System.Collections.Generic;

namespace array
{
    public class MatrixSpiralTraversal
    {
        public static void Run() {
            int[][] matrix = new int [][] {
                new int[] { 1,  2,  3, 4 },
                new int[] { 5,  6,  7, 8 },
                new int[] { 9, 10, 11, 12 },
                new int[] {13, 14, 15, 16 }
            };
            Print(matrix, SpiralOrder(matrix));
        }

//             left       right
//              \/         \/
//           |-----|-----|-----|
//  top ->   |     |     |     |
//           |-----|-----|-----|
//           |     |     |     |
//           |-----|-----|-----|
// bottom -> |     |     |     |
//           |-----|-----|-----|
//
        public static List<int> SpiralOrder(int[][] matrix) {
            List<int> result = new List<int>();

            int top = 0;
            int bottom = matrix.Length - 1;
            int left = 0;
            int right = matrix[0].Length - 1;

            while (top <= bottom && left <= right) {
                // Walk top fence
                for (int col = left; col <= right; col++) {
                    result.Add(matrix[top][col]);
                }
                top++;

                // Walk right fence
                for (int row = top; row <= bottom; row++) {
                    result.Add(matrix[row][right]);
                }
                right--;

                /*
                * If center is a horizontal line, prevent the bottom from rereading what the
                * top row already read.
                */
                if (top <= bottom) {
                    // Walk bottom fence
                    for (int col = right; col >= left; col--) {
                        result.Add(matrix[bottom][col]);
                    }
                }
                bottom--;

                /*
                * If center is a vertical line, prevent the left from rereading what the right
                * col already read.
                */
                if (left <= right) {
                    // Walk left fence
                    for (int row = bottom; row >= top; row--) {
                        result.Add(matrix[row][left]);
                    }
                }
                left++;
            }

            return result;
        }

        public static void Print(int[][] matrix, List<int> result) {
            Console.WriteLine("Input: ");
            Display.Matrix(matrix);
            Console.WriteLine($"Output: [ {String.Join(", ", result)} ]\n");    
        }
    }
}