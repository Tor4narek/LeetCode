public class Solution {
    public int FindCircleNum(int[][] isConnected) {
       int n = isConnected.Length; 
        HashSet<int> visited = new HashSet<int>(); 
        int provinces = 0;

        void DFS(int city)
        {
            if (visited.Contains(city)) return;
            visited.Add(city);
            
            for (int i = 0; i < n; i++)
            {
                if (isConnected[city][i] == 1 && !visited.Contains(i))
                {
                    DFS(i);
                }
            }
        }

        for (int i = 0; i < n; i++)
        {
            if (!visited.Contains(i))
            {
                DFS(i);
                provinces++; 
            }
        }

        return provinces;
    }
}
