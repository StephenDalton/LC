//https://leetcode.com/problems/inorder-successor-in-bst/discuss/72656/JavaPython-solution-O(h)-time-and-O(1)-space-iterative
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public TreeNode InorderSuccessor(TreeNode root, TreeNode p) {
        
        TreeNode successor = null;
        
        while (root != null) 
        {
            if (p.val < root.val) 
            {
                successor = root;
                root = root.left;
            }
            else
                root = root.right;
        }
        
        return successor;
    }
}
