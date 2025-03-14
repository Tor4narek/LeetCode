public class Solution {
    public int MinReorder(int n, int[][] connections) {
        var graph = new Dictionary<int, List<(int, bool)>>();

 
        for (int i = 0; i < n; i++) {
            graph[i] = new List<(int, bool)>();
        }

   
        foreach (var conn in connections) {
            graph[conn[0]].Add((conn[1], true));  
            graph[conn[1]].Add((conn[0], false)); 
        }

        var visited = new HashSet<int>();
        int res = 0;

        void DFS(int city) {
            visited.Add(city);
            foreach (var (nextCity, needsReversal) in graph[city]) {
                if (!visited.Contains(nextCity)) {
                    if (needsReversal) res++; 
                    DFS(nextCity);
                }
            }
        }

        DFS(0); 
        return res;
    }
}146
