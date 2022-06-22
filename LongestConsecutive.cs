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
        public int LongestConsecutive(int[] nums)
        {
            if (nums.Length < 2) return nums.Length;

            var sequence = new SortedSet<int>(nums);

            int length = 1; 
            int count = 0;
            while (sequence.Count != 0)
            {
                var v = sequence.First(); 
                while (sequence.Contains(v))
                {
                    sequence.Remove(v++);
                    count++;
                }
                if (length < count) length = count;
                count = 0;
            }
            return length;
        }
    }
}
