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
        public int LengthOfLongestSubstring(string s)
        {
            var charCounter = new HashSet<char>();

            int longest = 0;
            foreach (var c in s)
            {
                if (charCounter.Contains(c))
                {
                    charCounter.Clear();
                }
                charCounter.Add(c);
                longest = charCounter.Count > longest ? charCounter.Count : longest;
            }
            return longest;
        }
    }
}
