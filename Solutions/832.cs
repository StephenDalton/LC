//https://leetcode.com/problems/flipping-an-image/discuss/282410/Java-one-pass
public class Solution {
    public int[][] FlipAndInvertImage(int[][] image) {
        
        int n = image.Length;
        
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < (n + 1) / 2; j++) {
                int temp = image[i][j];
                image[i][j] = image[i][n - j - 1] ^ 1;
                image[i][n - j - 1] = temp ^ 1;
            }
        }
        return image;
    }
}
