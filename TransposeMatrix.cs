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
        public int[][] TransposeMatrix(int[][] matrix)
        {
            var result = new int[matrix[0].Length][];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = new int[matrix.Length];
                for (int j = 0; j < result[i].Length; j++)
                {
                    result[i][j] = matrix[j][i];
                }
            }
            return result;
        }
    }
}
