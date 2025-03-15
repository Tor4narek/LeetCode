public class Solution {
    public int PivotIndex(int[] nums) {
        var leftPrefix = 0;
        var rightPrefix = 0;
        var ln = nums.Length;
        var res = -1;
        for(var i=ln-1;i>0;i--){
            rightPrefix+=nums[i];
        }
         if(leftPrefix==rightPrefix){
                   res = 0;
        }
        for(var i = 1;i<ln;i++){
            leftPrefix+=nums[i-1];
            rightPrefix-=nums[i];
            if(leftPrefix==rightPrefix){
                if(res!=-1){
                    res = i<res?i:res;
                }
                else{
                    res = i;
                }
            }
        }
        return res;
    }
}
