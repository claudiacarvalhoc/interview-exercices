using System;

namespace array
{
    public class Matrix
    {
        public static void ToString(int[][] matrix) {
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
    }
}