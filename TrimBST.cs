using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    partial class Solution
    {
        public TreeNode TrimBST(TreeNode root, int low, int high)
        {
            if (root == null) return null;

            if (root.val > high)
            {
                return TrimBST(root.left, low, high);
            }
            if (root.val < low)
            {
                return TrimBST(root.right, low, high);
            }

            root.left = TrimBST(root.left, low, high);
            root.right = TrimBST(root.right, low, high);
            return root;
        }
    }
}
