class Solution {
public:
    int repeatedNTimes(vector<int>& nums) {
        unordered_map<int, int> freq;
        for (int x: nums){
            if(++freq[x] > 1) return x;
        }
        return -1;
        
    }
};
