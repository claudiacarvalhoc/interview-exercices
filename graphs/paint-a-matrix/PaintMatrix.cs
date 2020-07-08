using System;
using System.Collections.Generic;

namespace graphs.paint_a_matrix
{
    public class PaintMatrix
    {
        public int[][] Paint(int[][] image, int row, int col, int newColor)
        { 
            Queue<Tuple<int,int,int>> queue = new Queue<Tuple<int, int, int>>();
            HashSet<Tuple<int, int, int>> seen = new HashSet<Tuple<int, int, int>>();

            int regionOriginalValue = image[row][col];

            Tuple<int, int, int> start = new Tuple<int, int, int>(row, col, image[row][col]);
            queue.Enqueue(start);
            seen.Add(start);

            while (queue.Count > 0) {
                Tuple<int, int, int> curr = queue.Dequeue();

                // Perform work
                image[curr.Item1][curr.Item2] = newColor;

                // we need to find the adjacent vertices
                // but how? in the matrix we can perform the following route:
                //                          |    |     |     |      |
                //                                       /\ ( going up: row - 1)
                // (going left: col - 1)    |    | <-  | X   |  ->  | (going right> col + 1)
                //                                      \/ ( going down: row + 1)
                //                          |    |    |     |       |

                List<List<int>> directions = new List<List<int>> { new List<int> {0 , 1}, new List<int> {1, 0}, new List<int> {0, -1}, new List<int>{-1, 0} };
                foreach(List<int> direction in directions) {
                    int rowShift = direction[0];
                    int colShift = direction[1];

                    int newRow = curr.Item1 + rowShift;
                    int newCol = curr.Item2 + colShift;
                    
                    if (isInBounds(newRow, newCol, image)) { 
                        Tuple<int, int, int> next = new Tuple<int, int, int>(newRow, newCol, image[newRow][newCol]);
                        if (!seen.Contains(next) && next.Item3 == regionOriginalValue) {
                            queue.Enqueue(next);
                            seen.Add(next);
                        }
                    }
                }
            }

            return image;
        }

        private static bool isInBounds(int row, int col, int[][] image) {
            return row >= 0 && row < image.Length && col >= 0 && col < image[row].Length;
        }
    }
}