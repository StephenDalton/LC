//
public class Solution {
    public void ReverseString(char[] s) {
        int left = 0;
        int right = s.Length - 1;
        
        while(left < right)
        {
            char temp = s[left];
            s[left] = s[right];
            s[right] = temp;
            
            left++;
            right--;
        }
    }
}

/*
public class Solution {
    public void ReverseString(char[] s) {
        for (int i=0; i<s.Length / 2; i++)
        {
            char temp = s[i];
            s[i] = s[s.Length - i - 1];
            s[s.Length - i - 1] = temp;
        }
    }
}
*/
