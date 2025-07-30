public class Solution {
    public int LongestSubarray(int[] nums) {
        int maxVal = nums.Max();
        int longest = 0, current =0;

        foreach(int num in nums){
            if ( num == maxVal ){
                current++;
                longest = Math.Max(longest, current);
            } else {
                current = 0;
            }
        }
        return longest;
        
    }
}
