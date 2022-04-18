using System;

namespace leetcode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sln = new Solution();

            var tree = new TreeNode(5);
            tree.right = new TreeNode(6);
            tree.left = new TreeNode(3, new TreeNode(2, new TreeNode(1)), new TreeNode(4));
            var test = sln.KthSmallest(tree, 3);
        }
    }
}
