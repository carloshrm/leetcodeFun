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
        public bool IsPalindrome(string s)
        {
            var p = s.Where(x => Char.IsLetterOrDigit(x)).Select(x => Char.ToLower(x)).ToArray();
            for (int i = 0; i < p.Length; i++)
            {
                if (p[i] != p[p.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
