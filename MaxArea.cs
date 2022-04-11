using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    partial class Solution
    {
        public int MaxArea(int[] height)
        {
            int front = 0;
            int back = height.Length - 1;
            var area = height[front] < height[back] ?
                height[front] * (height.Length - 1):
                height[back] * (height.Length - 1);

            while (front < back)
            {
                var newArea = height[front] < height[back] ?
                    height[front] * (back - front) :
                    height[back] * (back - front);

                area = newArea > area ? newArea : area;

                if (height[front] < height[back])
                {
                    front++;
                }
                else
                {
                    back--;
                }

            }
            return area;
        }
    }
}
