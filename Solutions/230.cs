//https://leetcode.com/problems/kth-smallest-element-in-a-bst/discuss/63660/3-ways-implemented-in-JAVA-(Python)%3A-Binary-Search-in-order-iterative-and-recursive
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
    public int KthSmallest(TreeNode root, int k) {
        Stack<TreeNode> stack = new Stack<TreeNode>();
        TreeNode node = null;
        
        while (root != null)
        {
            stack.Push(root);
            root = root.left;
        }
        
        for (int i=0; i<k; i++)
        {
            node = stack.Pop();
            TreeNode right = node.right;
            
            while (right != null)
            {
                stack.Push(right);
                right = right.left;
            }
        }
        
        return node.val;
    }
}
