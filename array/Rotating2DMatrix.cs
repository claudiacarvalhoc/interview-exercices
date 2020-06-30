using System;

namespace array
{
    /**
    Given a two-dimensional square matrix (n x n), rotate the matrix 90 degrees to the right (clockwise).

    Example 1:

    Input:
    [
    [ 1,  2,  3, 4],
    [ 5,  6,  7, 8],
    [ 9, 10, 11, 12],
    [13, 14, 15, 16]
    ],

    Output:
    [
    [13,  9, 5, 1],
    [14, 10, 6, 2],
    [15, 11, 7, 3],
    [16, 12, 8, 4]
    ]


    Example 2:

    Input:
    [
    [10, 20],
    [30, 40]
    ],

    Output:
    [
    [30, 10],
    [40, 20]
    ]
    */

    public class Rotating2DMatrix
    {

        public static void Run() {
            int[][] matrix = new int [][] {
                new int[] { 1,  2,  3, 4 },
                new int[] { 5,  6,  7, 8 },
                new int[] { 9, 10, 11, 12 },
                new int[] {13, 14, 15, 16 }
            };
            Display.Matrix(matrix);
            int[][] result = rotate(matrix);
            Console.WriteLine("Result:");
            Display.Matrix(result);
        }

        public static int[][] rotate(int[][] matrix) {
            int size = matrix.Length - 1;

            for (int layer = 0; layer < matrix.Length / 2; ++layer) {
                for (int current = layer; current < size - layer; ++current) {
                    // Console.WriteLine($"layer: {layer} , current index: {current}");

                    int v_1 = matrix[layer][current];
                    int v_2 = matrix[current][size - layer];
                    int v_3 = matrix[size-layer][size-current];
                    int v_4 = matrix[size-current][layer];

                    // Console.WriteLine($"{v_1}, {v_2}, {v_3}, {v_4}");
                    
                    matrix[layer][current] = v_4;
                    matrix[current][size - layer] = v_1;
                    matrix[size-layer][size-current] = v_2;
                    matrix[size-current][layer] = v_3;
                }
            }

            return matrix;
        }
    }
}