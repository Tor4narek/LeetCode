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
    public int MaxLevelSum(TreeNode root) {
        var result = new Dictionary<int,int>();
        if(result==null){
            return result.MaxBy(entry => entry.Value).Key;
        }
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        var level = 1;
        while(queue.Count>0){
            var levelSize = queue.Count;
            var sum = 0;
            for(var i =0;i<levelSize;i++){
                var node = queue.Dequeue();
                sum+=node.val;

                if(node.left!=null){queue.Enqueue(node.left);}
                if(node.right!=null){queue.Enqueue(node.right);}
            }
            result[level] = sum;
            level++;
           
        }
        return  result.MaxBy(entry => entry.Value).Key;

    }
}
