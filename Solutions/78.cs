//https://leetcode.com/problems/subsets/discuss/27281/A-general-approach-to-backtracking-questions-in-Java-(Subsets-Permutations-Combination-Sum-Palindrome-Partitioning)
//https://leetcode.com/problems/palindrome-partitioning/discuss/182307/Java:-Backtracking-Template-General-Approach
//https://leetcode.com/problems/subsets/discuss/973667/Backtracking-Template-or-Explanation-%2B-Visual-or-Python
public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        List<IList<int>> results = new List<IList<int>>();
        
        backtrack(0, nums, new List<int>(), results);
        
        return results;
    }

    private void backtrack(int index, int [] nums, List<int> current, List<IList<int>> results) {
        results.Add(new List<int>(current));
        
        for (int i=index; i<nums.Length; i++)
        {
            current.Add(nums[i]);
            backtrack(i + 1, nums, current, results);
            current.RemoveAt(current.Count - 1);
        }
    }
}
