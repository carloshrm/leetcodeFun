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
        public int[][] GenerateMatrix(int n)
        {
            int[][] spiral = new int[n][].Select(x => new int[n]).ToArray();

            int value = 1;
            for (int i = 0; i < (n+1)/2; i++)
            {
                for (int j = i; j < n - i; j++)
                {
                    spiral[i][j] = value++;
                }
                for (int j = i + 1; j < n - i; j++)
                {
                    spiral[j][n - i - 1] = value++;
                }
                for (int j = i + 1; j < n - i; j++)
                {
                    spiral[n - i - 1][n - j - 1] = value++;
                }
                for (int j = i + 1; j < n - i - 1; j++)
                {
                    spiral[n - j - 1][i] = value++;
                }
            }
            return spiral;
        }
    }
}
