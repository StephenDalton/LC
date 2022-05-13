//https://leetcode.com/problems/validate-binary-search-tree/discuss/32109/My-simple-Java-solution-in-3-lines
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
    public bool IsValidBST(TreeNode root) {
        return IsValidBSTHelper(root, Int64.MinValue, Int64.MaxValue);
    }
    
    private bool IsValidBSTHelper(TreeNode root, long minVal, long maxVal)
    {
        if (root == null)
            return true;
        
        if (root.val >= maxVal || root.val <= minVal)
            return false;
        
        bool left = IsValidBSTHelper(root.left, minVal, root.val);
        bool right = IsValidBSTHelper(root.right, root.val, maxVal);
        
        return left && right;
    }
}
