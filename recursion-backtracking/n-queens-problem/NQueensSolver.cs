using System;
using System.Collections.Generic;

namespace recursion_backtracking.n_queens_problem
{
    public class NQueensSolver
    {
        public static List<char[][]> Solver(char[][] board) {
            List<char[][]> boards = new List<char[][]>();
            solveNQueens(0, 0, board, boards);
            return boards;
        }

        public static void solveNQueens(int row, int length, char[][] board, List<char[][]> validBoards) {
            if (row == board[0].Length) {
                validBoards.Add(board);
            }

            for (int col = 0; col < length; col++) {
                board[row][col] = 'Q';
                if (isValid(row, col, board)) {
                    solveNQueens(row + 1, col, board, validBoards);
                }
                board[row][col] = '-';
            }
        } 

        public static bool isValid(int row, int col, char[][] board) {
            
            // Check row of the placement
            for (int i = 0; i < board.Length; ++i) {
                if (board[row][i] == 'Q'){
                    return false;
                }
            }
            
            // Check column of the placement
            for (int i = 0; i < board.Length; ++i) {
                if (board[i][col] == 'Q'){
                    return false;
                }
            }

            // check left diagnal

            // check right diagnal


            return true;
        }
    }
}