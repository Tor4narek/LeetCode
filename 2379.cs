public class Solution {
    public int MinimumRecolors(string blocks, int k) {
        int minRecolors = int.MaxValue;
        int countW = 0;
        for (int i = 0; i < k; i++) {
            if (blocks[i] == 'W') {
                countW++;
            }
        }
        minRecolors = countW; 
        for (int i = k; i < blocks.Length; i++) {
            if (blocks[i - k] == 'W') {
                countW--; 
            }
            if (blocks[i] == 'W') {
                countW++; 
            }

            minRecolors = Math.Min(minRecolors, countW);
        }
        return minRecolors;
    }
}
