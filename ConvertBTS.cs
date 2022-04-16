namespace leetcode
{
    partial class Solution
    {
        public int treeSum = 0;
        public TreeNode ConvertBTS(TreeNode root)
        {
            if (root != null)
            {
                ConvertBTS(root.right);
                treeSum += root.val;
                root.val = treeSum;
                ConvertBTS(root.left);
            }
            return root;
        }
    }
}
