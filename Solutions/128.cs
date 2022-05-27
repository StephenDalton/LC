//
public class Solution {
    public int LongestConsecutive(int[] nums) {        
        int max = 0;
        HashSet<int> set = new HashSet<int>();
        
        foreach (int num in nums)
            set.Add(num);
        
        foreach (int num in set)
        {
            if (set.Contains(num - 1))
                continue;

            int count = 1;
            
            while (set.Contains(num + count))
                count++;
            
            max = Math.Max(max, count);        
        }
        
        return max;
    }
}
