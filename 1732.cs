public class Solution {
    public int LargestAltitude(int[] gain) {
        var ln = gain.Length;
        var prefixNum = 0;
        var prevPrefix = 0;
        var max = 0;
        for(var i=1;i<ln;i++){
           prefixNum=prevPrefix+gain[i-1];
           prevPrefix = prefixNum;
           max = prefixNum>max?prefixNum:max;
        }
        prefixNum =prevPrefix+gain[ln-1];
        max = prefixNum>max?prefixNum:max;
        return max;
    }
}
