//https://leetcode.com/problems/generate-parentheses/discuss/10100/Easy-to-understand-Java-backtracking-solution
public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        List<string> results = new List<string>();
        
        Backtrack(n, "", results, 0, 0);
        return results;
    }
    
    private void Backtrack(int n, string current, List<string> results, int openCount, int closeCount) {
        if (current.Length == n * 2)
        {
            results.Add(current);
            return;
        }
        
        if (openCount < n)
            Backtrack(n, current + "(", results, openCount + 1, closeCount);
        
        if (closeCount < openCount)
            Backtrack(n, current + ")", results, openCount, closeCount + 1);
    }
}
