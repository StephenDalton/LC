//https://leetcode.com/problems/find-smallest-letter-greater-than-target/discuss/1485910/Java-or-Runtime%3A-0ms-or-Faster-than-100.00
public class Solution {
    public char NextGreatestLetter(char[] letters, char target) {
        
        int low = 0;
        int high = letters.Length-1;
        
        if (target >= letters[letters.Length - 1])
            return letters[0];
        
        while (low <= high)
        {
            int mid = low + (high - low) / 2;
            
            if (target >= letters[mid])
                low = mid + 1;
            else if (target < letters[mid])
                high = mid - 1;
        }
        
        return letters[low];
    }
}
