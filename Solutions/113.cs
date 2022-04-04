//https://leetcode.com/problems/path-sum-ii/discuss/554411/C-solution
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
    public IList<IList<int>> PathSum(TreeNode root, int targetSum) {
        List<IList<int>> results = new List<IList<int>>();
        
        if(root == null)
            return results;
        
        DFS(root, targetSum, new List<int>(), results);
        return results;
    }
    
    private void DFS(TreeNode root, int target, List<int> path, List<IList<int>> results)
    {
        if(root == null)
            return;
        
        path.Add(root.val);
        
        if(root.left == null && root.right == null && root.val == target)
            results.Add(new List<int>(path));
        
        DFS(root.left, target - root.val, path, results);
        DFS(root.right, target - root.val, path, results);
        
        path.RemoveAt(path.Count - 1);
    }  
}
