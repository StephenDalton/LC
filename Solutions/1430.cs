//https://leetcode.com/problems/check-if-a-string-is-a-valid-sequence-from-root-to-leaves-path-in-a-binary-tree/discuss/604457/JavaPython-3-DFS-and-BFS-clean-codes-w-brief-comments-explanation-and-analysis.
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
    public bool IsValidSequence(TreeNode root, int[] arr) {
        return DFS(root, arr, 0);
    }
    
    private bool DFS(TreeNode root, int[] arr, int depth) {
        if (root == null || depth >= arr.Length || arr[depth] != root.val)
            return false;
        
        if (root.left == null && root.right == null)
            return arr.Length == depth + 1;
        
        bool left = DFS(root.left, arr, depth + 1);
        bool right = DFS(root.right, arr, depth + 1);
        
        return left || right;
    }
}
