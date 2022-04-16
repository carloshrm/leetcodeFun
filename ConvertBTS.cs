namespace leetcode
{
    partial class Solution
    {
        public int treeSum = 0;
        public TreeNode ConvertBST(TreeNode root)
        {
            if (root != null)
            {
                ConvertBST(root.right);
                treeSum += root.val;
                root.val = treeSum;
                ConvertBST(root.left);
            }
            return root;
        }
    }
}
