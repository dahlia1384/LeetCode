class Solution {
    public int firstUniqChar(String s) {
        int[] count = new int[26];

        for(int i = 0; i < s.length(); i++){
            count[s.charAt(i) - 'a']++;
        }

        for(int i =0; i < s.length();i++){
            if(count[s.charAt(i) - 'a' ]== 1){
                return i;
            }
        }

        return -1;
        
    }

    public static void main(String [] args){
        Solution solution = new Solution();

        System.out.println(solution.firstUniqChar("leetcode"));
        System.out.println(solution.firstUniqChar("loveleetcode"));
        System.out.println(solution.firstUniqChar("aabb"));
    }
}
