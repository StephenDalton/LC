//https://leetcode.com/problems/range-sum-of-bst/discuss/205181/Java-4-lines-Beats-100
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
    public int RangeSumBST(TreeNode root, int low, int high) {
        if (root == null)
            return 0;
        
        if (root.val > high)
            return RangeSumBST(root.left, low, high);
        if (root.val < low)
            return RangeSumBST(root.right, low, high);
        
        return root.val + RangeSumBST(root.left, low, high) + RangeSumBST(root.right, low, high);
    }
}

/*
public class Solution {
    public int RangeSumBST(TreeNode root, int low, int high) {
        return GetSumFromBST(root, low, high, 0);
    }
    
    private int GetSumFromBST(TreeNode root, int low, int high, int sum) {
        if (root == null)
            return sum;
        
        int left = GetSumFromBST(root.left, low, high, sum);
        int right = GetSumFromBST(root.right, low, high, sum);
        
        if (low <= root.val && root.val <= high)
            return left + right + root.val;
        
        return left + right;
    }
}
*/
