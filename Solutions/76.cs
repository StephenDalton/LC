//
public class Solution {
    public string MinWindow(string s, string t) {
        int[] frequency = new int[256];
        
        foreach (char c in t)
        {
            frequency[c]++;
        }
        
        int minStartIndex = 0;
        int minLength = Int32.MaxValue;
        
        int count = t.Length;
        
        int start = 0;
        int end = 0;
        
        while (end < s.Length)
        {
            if (frequency[s[end]] > 0)
                count--;
            
            frequency[s[end]]--;
            end++;
            
            while (count == 0)
            {
                if (end - start < minLength)
                {
                    minStartIndex = start;
                    minLength = end - start;
                }
                
                if (frequency[s[start]] >= 0)
                    count++;
                
                frequency[s[start]]++;
                start++;
            }
        }
        
        if (minLength != Int32.MaxValue)
            return s.Substring(minStartIndex, minLength);
        
        return "";
    }
}
