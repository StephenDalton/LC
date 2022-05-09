//https://leetcode.com/problems/longest-repeating-character-replacement/discuss/358879/Java-Solution-Explained-and-Easy-to-Understand-for-Interviews
public class Solution {
    public int CharacterReplacement(string s, int k) {
        
        int max = 0;
        int mostFreq = 0;
        int[] frequency = new int[256];
        
        int start = 0;
        int end = 0;
        
        while (end < s.Length)
        {
            frequency[s[end]]++;
            mostFreq = Math.Max(mostFreq, frequency[s[end]]);
            end++;
            
            if ((end - start) - mostFreq > k)
            {
                frequency[s[start]]--;
                start++;
            }
            
            max = Math.Max(max, end - start);
        }
        
        return max;
    }
}
