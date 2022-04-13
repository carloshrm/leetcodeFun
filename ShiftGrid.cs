using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    partial class Solution
    {
        public void GameOfLife(int[][] board)
        {
            int row = board.Length;
            int col = board[0].Length;

            Array.Copy(runCycle(), board, row);

            int[][] runCycle()
            {
                var cycle = new int[row][].Select(x => new int[col].ToArray()).ToArray();
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        int neighbors = countNeighbors(i, j);
                        cycle[i][j] = board[i][j];
                            
                        if (board[i][j] == 1 && (neighbors > 3 || neighbors < 2))
                        {
                            cycle[i][j] = 0;
                        }
                        else if (board[i][j] == 0 && neighbors == 3)
                        {
                            cycle[i][j] = 1;
                        }
                    }
                }
                return cycle;
            }

            int countNeighbors(int x, int y)
            {
                int count = 0;
                for (int i = -1; i < 2; i++)
                {
                    for (int j = -1; j < 2; j++)
                    {
                        int shiftX = i + x;
                        int shiftY = j + y;
                        if (shiftX < 0 || shiftX >= row || shiftY < 0 || shiftY >= col)
                        {
                            continue;
                        }
                        if (i == 0 && j == 0)
                        {
                            continue;
                        }
                        else
                        {
                            if (board[shiftX][shiftY] == 1)
                            {
                                count++;
                            }
                        }
                    }
                }
                return count;
            }
        }
    }
}
