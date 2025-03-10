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
    public int PathSum(TreeNode root, int targetSum) {
        if (root == null) return 0;

       
        return PathSumCounter(root, (long)targetSum) 
             + PathSum(root.left, targetSum) 
             + PathSum(root.right, targetSum);
    }

    private int PathSumCounter(TreeNode root, long targetSum) {
        if (root == null) return 0;

      
        int count = root.val == targetSum ? 1 : 0;

        
        count += PathSumCounter(root.left, targetSum - root.val);
        count += PathSumCounter(root.right, targetSum - root.val);

        return count;
    }
}
