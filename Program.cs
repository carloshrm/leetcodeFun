using System;

namespace leetcode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sln = new Solution();

            var tree = new TreeNode(3, new TreeNode(1), new TreeNode(4, new TreeNode(2), null));
            sln.RecoverTree(tree);
        }
    }
}
