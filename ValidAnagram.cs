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
        public bool IsAnagram(string s, string t)
        {
            return s.ToCharArray().OrderBy(c => c).SequenceEqual(t.ToCharArray().OrderBy(c => c));
        }
    }
}
