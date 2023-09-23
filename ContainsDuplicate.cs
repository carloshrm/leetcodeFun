using System.Collections.Generic;

namespace leetcode;

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
