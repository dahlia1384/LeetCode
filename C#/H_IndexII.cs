public class Solution {
    public int HIndex(int[] citations) {
        Array.Sort(citations, (a, b) => b.CompareTo(a));

        int h = 0;
        for(int i = 0; i < citations.Length; i++){
            if (citations[i] >= i +1){
                h = i + 1;
            } else {
                break;
            }
        }

        return h;

        
    }
}
