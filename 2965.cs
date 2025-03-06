public class Solution {
    public  int[] FindMissingAndRepeatedValues(int[][] grid) {
        var set = new HashSet<int>();
        var resa = 0; 
        var resb = 0; 

        foreach (var row in grid) {
            foreach (var v in row) {
                if (!set.Add(v)) {
                    resa = v; 
                }
            }
        }
        int n = grid.Length;
        for (int i = 1; i <= n * n; i++) {
            if (!set.Contains(i)) {
                resb = i; 
                break;
            }
        }
        return new int[] { resa, resb };
    }
}
