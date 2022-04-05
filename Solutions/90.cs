//https://leetcode.com/problems/subsets/discuss/27281/A-general-approach-to-backtracking-questions-in-Java-(Subsets-Permutations-Combination-Sum-Palindrome-Partitioning)
public class Solution {
    public IList<IList<int>> SubsetsWithDup(int[] nums) {
        List<IList<int>> results = new List<IList<int>>();
        
        Array.Sort(nums);
        Backtrack(0, nums, new List<int>(), results);
        
        return results;
    }
    
    private void Backtrack(int index, int[] nums, List<int> current, List<IList<int>> results) {
        results.Add(new List<int>(current));
        
        for (int i=index; i<nums.Length; i++)
        {
            if (i > index && nums[i] == nums[i - 1]) 
                continue;
            
            current.Add(nums[i]);
            Backtrack(i + 1, nums, current, results);
            current.RemoveAt(current.Count - 1);
        }
    }
}
