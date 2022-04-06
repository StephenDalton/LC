//https://leetcode.com/problems/generalized-abbreviation/discuss/77190/Java-backtracking-solution
public class Solution {
    public IList<string> GenerateAbbreviations(string word) {
        List<string> results = new List<string>();
        
        Backtrack(word, "", results, 0, 0);
        return results;
    }

    private void Backtrack(string word, string current, List<string> results,  int index, int count) {
        if(index == word.Length)
        {
            if(count > 0) 
                current += count;
            
            results.Add(current);
            return;
        }

        Backtrack(word, current, results, index + 1, count + 1);
        
        if (count > 0)
            current = current + count + word[index];
        else
            current = current + word[index];
        
        Backtrack(word, current, results, index + 1, 0);
    }
}
