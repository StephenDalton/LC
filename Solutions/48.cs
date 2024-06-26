//https://leetcode.com/problems/rotate-image/discuss/18879/AC-Java-in-place-solution-with-explanation-Easy-to-understand.
public class Solution {
    public void Rotate(int[][] matrix) {
        int n = matrix.Length;
        
        for(int i=0; i<n; i++)
        {
            for(int j=i; j<n; j++)
            {
                int temp = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] = temp;
            }
        }
        
        for(int i=0; i<n; i++)
        {
            for(int j=0; j<n/2; j++)
            {
                int temp = matrix[i][j];
                matrix[i][j] = matrix[i][n-j-1];
                matrix[i][n-j-1] = temp;
            }
        }
    }
}
