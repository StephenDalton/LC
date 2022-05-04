//
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int max = 0;
        
        int[] map = new int[256];
        
        int start = 0;
        int end = 0;
        
        while (end < s.Length)
        {
            map[s[end]]++;
            end++;
            
            while (map[s[end - 1]] > 1)
            {
                map[s[start]]--;
                start++;
            }
            
            max = Math.Max(max, end - start);
        }
        
        return max;
    }
}
