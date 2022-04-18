using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    partial class Solution
    {

        public int KthSmallest(TreeNode root, int k)
        {
            var values = new List<int>();
            dfs(root);

            void dfs(TreeNode r)
            {
                if (r == null) return;                
                dfs(r.left);
                values.Add(r.val);
                dfs(r.right);
            }
            return values[k - 1];
        }
    }
}
