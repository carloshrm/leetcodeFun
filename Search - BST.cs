using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    partial class Solution
    {
        public TreeNode SearchBST(TreeNode root, int val)
        {
            if (root == null) return null;

            if (root.val == val)
            {
                return root;
            }

            if (val > root.val)
            {
                return SearchBST(root.right, val);
            } else if (val < root.val)
            {
                return SearchBST(root.left, val);
            }
            return null;
        }
    }
}
