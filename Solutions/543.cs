//https://leetcode.com/problems/diameter-of-binary-tree/discuss/1781151/Java-Code-with-notes
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
    int length = 0;
    
    public int DiameterOfBinaryTree(TreeNode root) {
        if (root.left == null && root.right == null)
            return 0;
        
        DFS(root);
        
        return length;
    }
    
    private int DFS(TreeNode root)
    {
        if (root == null)
            return 0;
        
        int left = DFS(root.left);
        int right = DFS(root.right);
        
        length = Math.Max(length, left + right);
        
        return Math.Max(left, right) + 1;
    }
}
