public class Solution {
    public string MergeAlternately(string word1, string word2) {
        var result = "";
        var l1 = word1.Length;
        var l2 = word2.Length;
        int wl = l1>=l2?l1:l2;
        for(var i=0;i<wl;i++){
            if(i<l1){
                  result+=word1[i];
            }
            if(i<l2){
                result+=word2[i];
            }
              
                
        }
       
         return result;
    }
}
