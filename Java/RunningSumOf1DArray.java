class Solution {
    public static int[] runningSum(int[] nums) {
        for (int i = 1; i < nums.length; i++) {
            nums[i] += nums[i - 1];


        }

        return nums;
        
    }

    public static void main(String [] args){
        int[] nums1 = {1,2,3,4};
        int[] nums2 = {1,1,1,1,1};
        int[] nums3= {3,1,2,10,1};

        System.out.println(Arrays.toString(runningSum(nums1)));
        System.out.println(Arrays.toString(runningSum(nums2)));
        System.out.println(Arrays.toString(runningSum(nums3)));
    }
}
