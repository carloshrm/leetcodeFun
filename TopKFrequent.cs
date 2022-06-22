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
        public int[] TopKFrequent(int[] nums, int k)
        {
            var countHolder = new Dictionary<int, int>();
            foreach (var n in nums)
            {
                if (!countHolder.ContainsKey(n))
                {
                    countHolder.Add(n, k);
                } else
                {
                    countHolder[n]++;
                }
            }           
            return countHolder.OrderByDescending(k => k.Value).Select(x => x.Key).ToArray()[0..k];
        }
    }
}
