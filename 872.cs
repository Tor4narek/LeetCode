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
    
    public bool LeafSimilar(TreeNode root1, TreeNode root2) {
        var lasts1 = new List<int>();
        var lasts2 = new List<int>();
       PreOrder(root1,lasts1);
       PreOrder(root2,lasts2);
      if (lasts1.SequenceEqual(lasts2)) {
    return true;
} else {
    return false;
}
    }
    
    public void PreOrder(TreeNode root, List<int> lasts ) {
    if (root == null) return;
    if (root.left==null && root.right == null){
        lasts.Add(root.val);
    }
    
    PreOrder(root.left,lasts);
    PreOrder(root.right,lasts);
}
 
}
