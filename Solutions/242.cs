//
public class Solution {
    public bool IsAnagram(string s, string t) {
        
        if (s.Length != t.Length)
            return false;
        
        int[] frequency = new int[256];
        
        foreach (char c in t)
        {
            frequency[c]++;
        }
        
        int count = t.Length;
        
        foreach (char c in s)
        {
            if (frequency[c] > 0)
                count--;
            else 
                return false;
            
            frequency[c]--;
        }
        
        return true;
    }
}


/*
public class Solution {
    public bool IsAnagram(string s, string t) {
        
        if(s == null || t == null || s.Length != t.Length) return false;
        
        Dictionary<char, int> dictionary = new Dictionary<char, int>();
        
        foreach(var ch in t)
        {
            if(dictionary.ContainsKey(ch))
                dictionary[ch]++;
            else
                dictionary.Add(ch, 1);
        }
        
        for(int i=0; i<s.Length; i++)
        {
            if(dictionary.ContainsKey(s[i]))
            {
                if(dictionary[s[i]] == 1)
                    dictionary.Remove(s[i]);
                else
                    dictionary[s[i]]--;
            }
        }
        
        return dictionary.Count == 0;
    }
}
*/
