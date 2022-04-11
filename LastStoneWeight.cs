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
        public int LastStoneWeight(int[] stones)
        {

            Array.Sort(stones);
            var newStones = new List<int>(stones);
            while (newStones.Count() > 1)
            {
                var leftover = newStones.TakeLast(2).Aggregate((a, b) => b - a);
                newStones = newStones.GetRange(0, newStones.Count() - 2);
                if (leftover > 0)
                {
                    var leftoverIndex = newStones.FindIndex(x => x >= leftover);
                    newStones.Insert((leftoverIndex >= 0 ? leftoverIndex : newStones.Count()), leftover);
                }                
            }
            return newStones.DefaultIfEmpty(0).FirstOrDefault();
        }
    }
}
