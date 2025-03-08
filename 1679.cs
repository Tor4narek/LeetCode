public class Solution {
    public int MaxOperations(int[] nums, int k) {
            Array.Sort(nums);
        var counter = 0;
        var left =0;
        var right = nums.Length-1;
        while(left<right){
            var sum = nums[left]+nums[right];
            if(sum==k){
                counter++;
                left++;
                right--;
            }
            else if(sum>k){
                right--;
            }
            else{
               left++;
            }
        }
        return counter;

    }
}
