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
    private int max = Int32.MinValue;
    
    public int MaxPathSum(TreeNode root) {
        DFS(root);
        
        return max;
    }
    
    private int DFS(TreeNode root) {
        if (root == null)
            return 0;
        
        int left = Math.Max(DFS(root.left), 0);
        int right = Math.Max(DFS(root.right), 0);
        
        max = Math.Max(max, left + right + root.val);
        
        return Math.Max(left, right) + root.val;
    }
}
