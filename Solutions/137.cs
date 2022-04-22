//https://leetcode.com/problems/single-number-ii/discuss/1501849/Easy-to-read-commented-and-explained-C%2B%2B-solution
public class Solution {
    public int SingleNumber(int[] nums) {
        int oneCounter = 0;
        int twoCounter = 0;
        
        foreach (int n in nums) 
        {
            oneCounter = (oneCounter ^ n) & ~twoCounter;
            twoCounter = (twoCounter ^ n) & ~oneCounter;
        }
        
        return oneCounter;
    }
}
