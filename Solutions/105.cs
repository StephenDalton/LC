//
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
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        Stack<TreeNode> stack = new Stack<TreeNode>();
        
        TreeNode root = new TreeNode(preorder[0]);
        stack.Push(root);
        
        int inorderIndex = 0;
        
        for (int i=1; i<preorder.Length; i++)
        {
            TreeNode node = null;
            TreeNode curr = new TreeNode(preorder[i]);
            
            while (stack.Count > 0 && stack.Peek().val == inorder[inorderIndex])
            {
                node = stack.Pop();
                inorderIndex++;
            }
            
            if (node == null) 
                stack.Peek().left = curr;
            else 
                node.right = curr;
            
            stack.Push(curr);
        }
        
        return root;
    }
}

/*
public class Solution {
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        
        return buildTree(preorder, inorder, 0, 0, inorder.Length - 1);
    }
    
    private TreeNode BuildTreeHelper(int[] preorder, int[] inorder, int preorderIndex, int start, int end) {
        if (start > end) 
            return null;
        
        TreeNode node = new TreeNode(preorder[preorderIndex]);
        int inorderIndex = -1;
        
        for (int i = start; i <= end; i++) 
        {
            if (inorder[i] == preorder[preorderIndex]) 
                inorderIndex = i;
        }
        
        int leftTreeSize = inorderIndex - start;
        int rightTreeSize = end - inorderIndex;
        
        node.left = BuildTreeHelper(preorder, inorder, preorderIndex + 1, start, inorderIndex - 1);
        node.right = BuildTreeHelper(preorder, inorder, preorderIndex + leftTreeSize + 1, inorderIndex + 1, end);
        
        return node;
    }
}
*/
