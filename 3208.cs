public class Solution {
    public int NumberOfAlternatingGroups(int[] colors, int k)
    {
        int ln = colors.Length;
        int result = 0;
        int count = 1;
        
        for (int i = 1; i < ln + k - 1; i++)
        {
            if (colors[i % ln] != colors[(i - 1) % ln])
            {
                count++;
            }
            else
            {
                count = 1;
            }
            
            if (i >= k - 1 && count == k)
            {
                result++;
                count--; 
            }
        }
        
        return result;
    }
}
