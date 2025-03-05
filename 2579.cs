public class Solution {
    public long ColoredCells(int n) {
        long a = (long)n * n;
        long b = (long)(n - 1) * (n - 1);
        return a + b;
    }
}
