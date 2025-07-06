public class Solution {
    // you need treat n as an unsigned value
    public int reverseBits(int n) {
        int result = 0;

        for (int i = 0; i < 32; i++){
            result <<= 1; //Shift results to the left for space
            result |= (n&1);
            n >>>=1; //Unsigned right shift for n
        }

        return result;
        
    }
}
