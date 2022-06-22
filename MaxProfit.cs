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
        public int MaxProfit(int[] prices)
        {
            if (prices.Length <= 1) return 0;
            int sell = prices[0];
            int profit = 0;            
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < sell)
                    sell = prices[i];
                else
                    profit = Math.Max(profit, prices[i] - sell);
            }
            return profit;
        }
    }
}
