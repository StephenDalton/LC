//https://leetcode.com/problems/unique-number-of-occurrences/
public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        
        Dictionary<int, int> dictionary = new Dictionary<int, int>();
        HashSet<int> occurences = new HashSet<int>();
        
        foreach (int n in arr)
        {
            if (!dictionary.ContainsKey(n))
                dictionary.Add(n, 1);
            else
                dictionary[n]++;
        }
        
        foreach (var n in dictionary)
        {
            if (!occurences.Contains(n.Value))
                occurences.Add(n.Value);
            else
                return false;
        }
        
        return true;
    }
}
