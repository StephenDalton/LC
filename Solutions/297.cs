//https://leetcode.com/problems/serialize-and-deserialize-binary-tree/discuss/281714/Clean-Java-Solution
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Codec {

    // Encodes a tree to a single string.
    public string serialize(TreeNode root) {
        if (root == null) 
            return ":";
        
        return root.val + "," + serialize(root.left) + "," + serialize(root.right);
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data) {
        List<string> nodes = data.Split(",").ToList();
        Queue<string> queue = new Queue<string>(nodes);
        
        return helper(queue);
    }
    
    private TreeNode helper(Queue<string> queue) {
        string s = queue.Dequeue();
        
        if (s.Equals(":")) 
            return null;
        
        TreeNode root = new TreeNode(Int32.Parse(s));
        root.left = helper(queue);
        root.right = helper(queue);
        
        return root;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec ser = new Codec();
// Codec deser = new Codec();
// TreeNode ans = deser.deserialize(ser.serialize(root));
