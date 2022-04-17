using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    partial class Solution
    {
        public TreeNode IncreasingBST(TreeNode root)
        {
            var parsedTree = new TreeNode(0);
            var treeClimber = parsedTree;

            branchTrimmer(root);
            return parsedTree.right;

            void branchTrimmer(TreeNode branch)
            {
                if (branch == null) return;
                branchTrimmer(branch.left);
                branch.left = null;
                treeClimber.right = branch;
                treeClimber = branch;
                branchTrimmer(branch.right);
            }        
        }
    }
}
