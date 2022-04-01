//https://leetcode.com/problems/binary-tree-right-side-view/discuss/56230/Share-my-Java-iterative-solution-based-on-level-order-traversal/866335
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
    public IList<int> RightSideView(TreeNode root) {
        List<int> results = new List<int>();

        if (root == null) 
            return results;
        
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        
        while (queue.Count > 0)
        {
            TreeNode currentNode = null;
            int count = queue.Count();
            
            for (int i = 0; i < count; i++)
            {
                currentNode = queue.Dequeue();
                
                if (currentNode.left != null)
                    queue.Enqueue(currentNode.left);
                if (currentNode.right != null)
                    queue.Enqueue(currentNode.right);
            }
            //For each level, once the for loop breaks, currentNode will contain the right most element
            results.Add(currentNode.val);
        }
        
        return results;
    }
}
