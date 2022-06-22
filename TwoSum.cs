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
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[] { 0 };
        }

        public int[] TwoSumII(int[] numbers, int target)
        {
            int i = 0;
            int j = numbers.Length - 1;
            while (i < j)
            {
                int sum = numbers[i] + numbers[j];
                
                if (sum == target)
                    return new int[] { i + 1, j + 1 };
                
                if (sum > target)
                    j--;
                else
                    i++;
            }
            return new int[] { 0 };
        }
    }
}
