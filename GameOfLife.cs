using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    partial class Solution
    {        
        public IList<IList<int>> ShiftGrid(int[][] grid, int k)
        {
            int x = grid.Length;
            int y = grid[0].Length;

            var shifted = new List<IList<int>>(Enumerable.Range(0, x).Select(x => new List<int>(Enumerable.Range(0,y).Select(x => 0))));
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    int shiftI = ((i * y) + j + k) % (x * y);
                    int postI = shiftI / y;
                    int postJ = shiftI % y;
                    shifted[postI][postJ] = grid[i][j];
                }
            }
            return shifted;
        }
    }
}
