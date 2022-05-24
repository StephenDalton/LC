//https://leetcode.com/problems/clone-graph/discuss/42309/Depth-First-Simple-Java-Solution
/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/
public class Solution {
    public Node CloneGraph(Node node) {
        if (node == null)
            return null;
        return DFS(node, new Dictionary<int, Node>());
    }
    
    private Node DFS(Node node, Dictionary<int, Node> dictionary) {
        if (dictionary.ContainsKey(node.val))
            return dictionary[node.val];
        else
        {
            Node clone = new Node(node.val);
            dictionary.Add(clone.val, clone);
            
            for (int i=0; i<node.neighbors.Count; i++)
                clone.neighbors.Add(DFS(node.neighbors[i], dictionary));
            
            return clone;
        }
    }   
}
