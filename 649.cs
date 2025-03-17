public class Solution {
    public string PredictPartyVictory(string senate) {
        var direQueue = new Queue<int>();
        var radiantQueue = new Queue<int>();
        for(var i =0;i<senate.Length;i++){
           if(senate[i]=='R'){
            radiantQueue.Enqueue(i);
           }
           else{
            direQueue.Enqueue(i);
           }
        }

      while (radiantQueue.Count > 0 && direQueue.Count > 0) {
            int radiantIndex = radiantQueue.Dequeue();
            int direIndex = direQueue.Dequeue();

            if (radiantIndex < direIndex) {
                radiantQueue.Enqueue(radiantIndex + senate.Length);
            } else {
                direQueue.Enqueue(direIndex + senate.Length);
            }
        }
        return radiantQueue.Count > 0 ? "Radiant" : "Dire";
}}
