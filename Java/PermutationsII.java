class Solution {
    public List<List<Integer>> permuteUnique(int[] nums) {
        List<List<Integer>> results = new ArrayList<>();
        Arrays.sort(nums);
        boolean[] used = new boolean[nums.length];
        backtrack(nums, new ArrayList<>(), used, results);
        return results;
        
    }

    private void backtrack(int[] nums, List<Integer> path, boolean[] used, List<List<Integer>> results){
        if(path.size() == nums.length){
            results.add(new ArrayList<>(path));
            return;
        }

        for(int i = 0; i < nums.length; i++){
            if(used[i]) continue;

            if(i > 0 && nums[i] == nums[i-1] && !used[i-1]) continue;

            path.add(nums[i]);
            used[i] =true;
            backtrack(nums,path,used,results);
            used[i] = false;
            path.remove(path.size() -1);
            
        }
    }
}
