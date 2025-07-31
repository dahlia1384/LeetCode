public class Solution {
    public int SubarrayBitwiseORs(int[] arr) {
        HashSet<int> allResults = new HashSet<int>();
        HashSet<int> prev = new HashSet<int>();

        foreach(int num in arr){
            HashSet<int> curr = new HashSet<int>();
            curr.Add(num);

            foreach(int val in prev){
                curr.Add(val | num);
            }
            foreach(int val in curr){
                allResults.Add(val);
            }

            prev = curr;
        }
        
        return allResults.Count;
        
        
    }
}
