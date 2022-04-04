//https://leetcode.com/problems/sum-root-to-leaf-numbers/discuss/41363/Short-Java-solution.-Recursion./39619
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
    public int SumNumbers(TreeNode root) {
        return DFS(root, 0);
    }

    private int DFS(TreeNode root, int currentSum) {
        if (root == null) 
            return 0;
        
        currentSum = currentSum * 10 + root.val;
        
        if (root.left == null && root.right == null) 
            return currentSum;
        
        int leftSum = DFS(root.left, currentSum);
        int rightSum = DFS(root.right, currentSum);
        
        return leftSum + rightSum;
    }
}
