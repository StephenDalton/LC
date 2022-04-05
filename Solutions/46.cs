//https://leetcode.com/problems/permutations/discuss/18239/A-general-approach-to-backtracking-questions-in-Java-(Subsets-Permutations-Combination-Sum-Palindrome-Partioning)
public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        List<IList<int>> results = new List<IList<int>>();
        
        Backtrack(nums, new List<int>(), results);
        
        return results;
    }

    private void Backtrack(int[] nums, List<int> current, List<IList<int>> results) {
        if (current.Count == nums.Length)
        {
            results.Add(new List<int>(current));
            return;
        }
        
        for (int i=0; i<nums.Length; i++)
        {
            if (current.Contains(nums[i]))
                continue;
            
            current.Add(nums[i]);
            Backtrack(nums, current, results);
            current.Remove(nums[i]);
        }
    }
}
