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
        public int Trap(int[] height)
        {
            var areaSum = 0;
            for (int i = 0; i < height.Length; i++)
            {
                if (height[i] == 0)
                {
                    continue;
                } else
                {
                    int front = i;
                    int back = i + 1;
                    while (height[front] >= height[back])
                    {
                        back++;
                    }   
                }
            }
            return 0;
        }
    }
}
