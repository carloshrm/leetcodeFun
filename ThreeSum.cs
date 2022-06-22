
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
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var sortedNums = nums.OrderBy(x => x).ToArray();

            var triplets = new List<IList<int>>();

            for (int i = 0; i < nums.Length; i += 1)
            {
                int j = i + 1;
                int k = nums.Length - 1;
                if (i > 0 && sortedNums[i - 1] == sortedNums[i]) continue;
                while (j < k)
                {
                    int sum = sortedNums[i] + sortedNums[j] + sortedNums[k];

                    if (sum > 0)
                    {
                        k--;
                    }
                    else if (sum < 0)
                    {
                        j++;
                    }
                    else
                    {
                        triplets.Add(new int[] { sortedNums[i], sortedNums[j], sortedNums[k] });
                        j++;
                        while (sortedNums[j] == sortedNums[j - 1] && j < k) j++;
                    }
                }
            }
            return triplets;
        }
    }

}
