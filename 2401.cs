public class Solution {
    public int LongestNiceSubarray(int[] nums) {
        int left = 0, usedBits = 0, maxLength = 0;

        for (int right = 0; right < nums.Length; right++) {
            while ((usedBits & nums[right]) != 0) {
                usedBits ^= nums[left]; 
                left++;
            }
            usedBits |= nums[right]; 
            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}
