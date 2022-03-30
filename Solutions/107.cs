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
    public IList<IList<int>> LevelOrderBottom(TreeNode root) {
        IList<IList<int>> results = new List<IList<int>>();
        
        if(root == null) 
            return results;
        
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        
        while(queue.Count > 0)
        {
            List<int> currentLevel = new List<int>();
            int count = queue.Count;
            
            for(int i=0; i<count; i++)
            {
                TreeNode currentNode = queue.Dequeue();
                currentLevel.Add(currentNode.val);
                
                if(currentNode.left != null)
                    queue.Enqueue(currentNode.left);
                if(currentNode.right != null)
                    queue.Enqueue(currentNode.right);
            }
            
            results.Insert(0, currentLevel);
        }
        
        return results;
    }
}
