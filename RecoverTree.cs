namespace leetcode
{
    partial class Solution
    {
        public void RecoverTree(TreeNode root)
        {
            TreeNode firstBroken = null;
            TreeNode secondBroken = null;
            TreeNode rearClimber = null;

            checkNodes(root);
            int valHolder = firstBroken.val;
            firstBroken.val = secondBroken.val;
            secondBroken.val = valHolder;

            void checkNodes(TreeNode frontClimber)
            {
                if (frontClimber == null) return;
                checkNodes(frontClimber.left);
                if (rearClimber != null && rearClimber.val > frontClimber.val)
                {
                    if (firstBroken == null)
                    {
                        firstBroken = rearClimber;
                    }
                    secondBroken = frontClimber;
                }
                rearClimber = frontClimber;
                checkNodes(frontClimber.right);
            }
        }
    }
}
