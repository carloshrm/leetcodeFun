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
        public int RemovePalindromeSub(string s)
        {
            int i = 0;
            int j = s.Length;

            while (i < j)
            {
                if (s[i] != s[j - 1]) return 2;
                i++;
                j--;
            }
            return 1;
        }
    }
}
