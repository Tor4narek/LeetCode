public class Solution {
    public void MoveZeroes(int[] nums) {
        var ln = nums.Count();
        var res  = new int[ln];
        var j = 0;
        for(var i=0;i<ln;i++){
            if(nums[i]!=0){
               nums[j]=nums[i];
               j++;
               
               
            }  
        }
        for(var k = j;k<ln;k++){
            nums[k]=0;
        }    
    }
}
