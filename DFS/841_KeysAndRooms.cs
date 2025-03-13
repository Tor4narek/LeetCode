public class Solution {
    public bool CanVisitAllRooms(IList<IList<int>> rooms) {
        var nrooms = new HashSet<int>();
        var n = rooms.Count;
       
       void DFS(int room){
         if(nrooms.Contains(room)){
          return;
        }
          nrooms.Add(room);
           foreach(var key in rooms[room]){
               DFS(key);   
        }
       }
       DFS(0);
       return nrooms.Count==n;
       
    }
}
