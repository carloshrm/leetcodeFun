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
        public bool ContainsDuplicate(int[] nums)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();
            foreach (var n in nums)
            {
                if (result.ContainsKey(n))
                {
                    return true;
                }
                else
                {
                    result.Add(n, n);
                }
            }
            return false;
        }
    }
}
