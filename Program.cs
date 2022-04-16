using System;

namespace leetcode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sln = new Solution();

            var tree = new TreeNode(4);
            tree.right= new TreeNode(6, new TreeNode(5), new TreeNode(7, null, new TreeNode(8)));
            tree.left = new TreeNode(1, new TreeNode(0), new TreeNode(2, null, new TreeNode(3)));
            var test = sln.ConvertBTS(tree);
            //Console.WriteLine(result);
        }
    }
}
