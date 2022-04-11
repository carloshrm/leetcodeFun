using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    partial class Solution
    {
        public int SplitArray(int[] nums, int m)
        {

            var sumBucket = new List<int>();
            for (int i = 0; i <= nums.Length - m; i++)
            {
                sumBucket.Add(nums[i..(i+m)].Sum());
            }
            return sumBucket.Max();
        }
    }
}
