//https://leetcode.com/problems/set-matrix-zeroes/discuss/26008/My-AC-java-O(1)-solution-(easy-to-read)
public class Solution {
    public void SetZeroes(int[][] matrix) {
        bool firstRow = false;
        bool firstCol = false;
        
        for (int i=0; i<matrix.Length; i++)
        {
            for (int j=0; j<matrix[0].Length; j++)
            {
                if (matrix[i][j] == 0)
                {
                    if (i == 0) firstRow = true;
                    if (j == 0) firstCol = true;
                    
                    matrix[0][j] = 0;
                    matrix[i][0] = 0;
                }
            }
        }
    
        for (int i=1; i<matrix.Length; i++)
        {
            for (int j=1; j<matrix[0].Length; j++)
            {
                if (matrix[0][j] == 0 || matrix[i][0] == 0)
                    matrix[i][j] = 0;
            }
        }
        
        if (firstRow)
        {
            for (int i=0; i<matrix[0].Length; i++)
            {
                matrix[0][i] = 0;
            }
        }
        
        if (firstCol)
        {
            for (int i=0; i<matrix.Length; i++)
            {
                matrix[i][0] = 0;
            }
        }
    }
}
