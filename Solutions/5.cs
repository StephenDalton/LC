//https://leetcode.com/problems/longest-palindromic-substring/discuss/2928/Very-simple-clean-java-solution/1312121
public class Solution {
    public string LongestPalindrome(string s) {
        int maxStartIndex = 0;
        int maxLength = 0;
        
        for (int i=0; i<s.Length; i++)
        {
            int s1 = ExpandFromCenter(s, i, i);
            int s2 = ExpandFromCenter(s, i - 1, i);
            
            int currentMax = Math.Max(s1, s2);
            
            if (currentMax > maxLength)
            {
                maxStartIndex = i - (currentMax / 2);
                maxLength = currentMax;
            }
        }
        
        return s.Substring(maxStartIndex, maxLength);
    }
    
    private int ExpandFromCenter(string s, int left, int right) {
        while (left >= 0 && right < s.Length)
        {
            if (s[left] != s[right])
                break;
            
            left--;
            right++;
        }
        
        return right - left - 1;
    }
}
