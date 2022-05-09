//
public class Solution {
    public int CountSubstrings(string s) {
        int count = 0;
        
        for (int i=0; i<s.Length; i++)
        {
            count += ExpandFromCenter(s, i, i);
            count += ExpandFromCenter(s, i - 1, i);
        }
        
        return count;
    }
    
    private int ExpandFromCenter(string s, int left, int right) {
        int count = 0;
        
        while (left >= 0 && right < s.Length)
        {
            if (s[left] != s[right])
                break;
            
            count++;
            
            left--;
            right++;
        }
        
        return count;
    }
}
