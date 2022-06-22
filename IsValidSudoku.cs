using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    partial class Solution
    {
        public bool IsValidSudoku(char[][] board)
        {
            var rows = new HashSet<char>();
            var cols = new HashSet<char>[board.Length].Select(x => x = new HashSet<char>()).ToArray();
            var boxes = new HashSet<char>[board.Length].Select(x => x = new HashSet<char>()).ToArray();

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    if (board[i][j] == '.') continue;

                    if (rows.Contains(board[i][j]))
                        return false;
                    else
                        rows.Add(board[i][j]);

                    if (cols[j].Contains(board[i][j]))
                        return false;
                    else
                        cols[j].Add(board[i][j]);

                    if (boxes[i / 3 * 3 + (j / 3)].Contains(board[i][j]))
                        return false;
                    else
                        boxes[i / 3 * 3 + (j / 3)].Add(board[i][j]);
                }
                rows = new HashSet<char>();
            }
            return true;

        }
    }
}


