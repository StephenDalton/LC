//https://leetcode.com/problems/contains-duplicate/discuss/1157635/C-solutions
public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        
        HashSet<int> set = new HashSet<int>();
        
        for (int i=0; i<nums.Length; i++)
        {
            if (set.Contains(nums[i]))
                return true;
            else 
                set.Add(nums[i]);
        }
        
        return false;
    }
}
