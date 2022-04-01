//https://leetcode.com/problems/populating-next-right-pointers-in-each-node/discuss/1764851/Java-BFS-and-DFS-4-Solutions
/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}
*/

public class Solution {
    public Node Connect(Node root) {
        
        if (root == null)
            return null;
        
        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(root);
        
        while (queue.Count > 0)
        {
            int count = queue.Count;
            Node prev = queue.Dequeue();
            
            if (prev.left != null)  //Only need to check one side since it's a perfect binary tree
            {
                queue.Enqueue(prev.left);
                queue.Enqueue(prev.right);
            }
            
            for (int i=1; i<count; i++)
            {
                Node currentNode = queue.Dequeue();
                prev.next = currentNode;
                
                if (currentNode.left != null)
                {
                    queue.Enqueue(currentNode.left);
                    queue.Enqueue(currentNode.right);
                }
                    
                prev = currentNode;
            }
            
        }
        return root;
    }
}
