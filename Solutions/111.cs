//https://leetcode.com/problems/minimum-depth-of-binary-tree/discuss/36045/My-4-Line-java-solution
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

//  BFS Solution

public class Solution {
    public int MinDepth(TreeNode root) {
        if(root == null) 
            return 0;
        
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        
        int depth = 1;
        
        while(queue.Count > 0)
        {
            int count = queue.Count;

            for(int i=0; i<count; i++)
            {
                TreeNode currentNode = queue.Dequeue();
                
                if(currentNode.left == null && currentNode.right == null)
                    return depth;

                if(currentNode.left != null)
                    queue.Enqueue(currentNode.left);
                if(currentNode.right != null)
                    queue.Enqueue(currentNode.right);
            }
            depth++;
        }
        
        return depth;
    }
}


//  DFS Solution

public class SolutionDFS {
    public int MinDepth(TreeNode root) {
        if (root == null)
            return 0;
        
        if (root.left == null)
            return MinDepth(root.right) + 1;
        
        if (root.right == null)
            return MinDepth(root.left) + 1;
        
        return Math.Min(MinDepth(root.left),MinDepth(root.right)) + 1;
    }
}

/*
    public int MinDepth(TreeNode root) {
        if (root == null)
            return 0;
        
        int left = MinDepth(root.left);
        int right = MinDepth(root.right);
        
        if (root.left != null && root.right != null)
            return Math.Min(left, right) + 1;
        else
            return Math.Max(left, right) + 1;
    }
*/
