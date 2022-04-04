//https://leetcode.com/problems/path-sum-iii/discuss/91884/Simple-AC-Java-Solution-DFS
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
    public int PathSum(TreeNode root, int targetSum) {
        if (root == null)
            return 0;
        
        int result = findPath(root, targetSum);
        
        int left = PathSum(root.left, targetSum);
        int right = PathSum(root.right, targetSum);
        
        return result + left + right;
    }
    
    public int findPath(TreeNode root, int targetSum){
        int result = 0;
        
        if (root == null)
            return 0;
        
        if (root.val == targetSum)
            result++;
        
        int left = findPath(root.left, targetSum - root.val);
        int right = findPath(root.right, targetSum - root.val);
        
        return result + left + right;
    }
}
