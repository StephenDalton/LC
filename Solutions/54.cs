//https://leetcode.com/problems/spiral-matrix/discuss/20570/Clean-Java-readable-human-friendly-code
public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        List<int> results = new List<int>();
        
        int top = 0;
        int right = matrix[0].Length - 1;
        int bottom = matrix.Length - 1;
        int left = 0;
        
        int matrixCount = matrix.Length * matrix[0].Length;
        
        while (results.Count < matrixCount)
        {
            for (int i=left; i <= right && results.Count < matrixCount; i++)
                results.Add(matrix[top][i]);
            top++;
            
            for (int i=top; i <= bottom && results.Count < matrixCount; i++)
                results.Add(matrix[i][right]);
            right--;
            
            for (int i=right; i >= left && results.Count < matrixCount; i--)
                results.Add(matrix[bottom][i]);
            bottom--;
            
            for (int i=bottom; i >= top && results.Count < matrixCount; i--)
                results.Add(matrix[i][left]);
            left++;
        }
        
        return results;
    }
}
