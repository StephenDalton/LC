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
    int diameter = 0;
    
    public int DiameterOfBinaryTree(TreeNode root) {
        if (root.left == null && root.right == null) 
            return 0;

        height(root);
        
        return diameter;
    }

    private int height(TreeNode root) {
        if (root == null) 
            return 0;

        int leftHeight = height(root.left);
        int rightHeight = height(root.right);

        diameter = Math.Max(diameter, leftHeight + rightHeight);

        return Math.Max(leftHeight, rightHeight) + 1;
    }
}
