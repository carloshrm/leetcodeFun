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
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var countSet = new Dictionary<string, List<string>>();
            for (int i = 0; i < strs.Length; i++)
            {
                var sortedWord = string.Join("", strs[i].OrderBy(c => c));
                if (countSet.ContainsKey(sortedWord))
                {
                    countSet[sortedWord].Add(strs[i]);

                }
                else
                {
                    countSet.Add(sortedWord, new List<string> { strs[i] });
                }
            }
            IList<IList<string>> result = new List<IList<string>>();
            foreach (var set in countSet.Values)
            {
                result.Add(set);
            }
            return result;
        }
    }

}