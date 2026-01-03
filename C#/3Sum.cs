using System;
using System.Collections.Generic; 

public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
       var res = new List<IList<int>>();
        if (nums == null || nums.Length < 3) return res;

        Array.Sort(nums);
        int n = nums.Length;

        for (int i = 0; i < n - 2; i++) {
            if (i > 0 && nums[i] == nums[i - 1]) continue;
            if (nums[i] > 0) break;

            int left = i + 1;
            int right = n - 1;

            while (left < right) {
                int sum = nums[i] + nums[left] + nums[right];

                if (sum == 0) {
                    res.Add(new List<int> { nums[i], nums[left], nums[right] });

                    int lv = nums[left];
                    int rv = nums[right];

                    while (left < right && nums[left] == lv) left++;
                    while (left < right && nums[right] == rv) right--;
                }
                else if (sum < 0) {
                    left++;
                }
                else {
                    right--;
                }
            }
        }

        return res;
    }
}
