using System;

namespace recursion_backtracking.sudoku
{
    public class SudokuSolver
    {
        
        public static int[][] Solver(int[][] board) {
            FillBoard(0, 0, board);
            return board;
        }

        public static bool FillBoard(int row, int col, int[][] board) {
            if (col == board[0].Length) {
                row++;
                col = 0;
                if (row == board.Length) {
                    return true;
                }
            }

            if (board[row][col] > 0) {
                return FillBoard(row, col + 1, board);
            }

            for (int i = 0; i <= 9; ++i) {
                board[row][col] = i;
                if (isBoardValid(row, col, board)) {
                    if (FillBoard(row, col + 1, board)) {
                        return true;
                    }
                }
            }

            board[row][col] = 0;
            return false;
        }

        public static bool isBoardValid(int row, int col, int[][] board) {
            int currentValue = board[row][col];
            
            // Check column of the placement
            foreach (int[] placementRow in board) {
                if (currentValue == placementRow[col]){
                    return false;
                }
            }

            // Check row of the placement
            for (int i = 0; i < board[row].Length; i++) {
                if (currentValue == board[row][i]) {
                    return false;
                }
            }

            // Check region constraints - get the size of the sub-box
            int regionSize = (int) Math.Sqrt(board.Length);

            int verticalBoxIndex = row / regionSize;
            int horizontalBoxIndex = col / regionSize;

            int topLeftOfSubBoxRow = regionSize * verticalBoxIndex;
            int topLeftOfSubBoxCol = regionSize * horizontalBoxIndex;

            for (int i = 0; i < regionSize; i++) {
               for (int j = 0; j < regionSize; j++) {
                    if (currentValue == board[topLeftOfSubBoxRow + i][topLeftOfSubBoxCol + j]) {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}