/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    private int maxLength = 0;

    public int LongestZigZag(TreeNode root) {
        if (root == null) return 0;
        ZigZag(root.left, "left", 1);
        ZigZag(root.right, "right", 1);
        return maxLength;
    }

    private void ZigZag(TreeNode root, string direction, int length) {
        if (root == null) return;

        maxLength = Math.Max(maxLength, length);

        if (direction == "left") {
            ZigZag(root.right, "right", length + 1);
            ZigZag(root.left, "left", 1);
        } else {
            ZigZag(root.left, "left", length + 1);
            ZigZag(root.right, "right", 1);
        }
    }
}
