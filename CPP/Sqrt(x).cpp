class Solution {
public:
    int mySqrt(int x) {
        if ( x < 2 ) {
            return x;

        }

        int left = 2;
        int right = x/2 ;

        while ( left <= right){
            long long mid = (left + right) /2;
            long long guess = mid * mid;

            if(guess == x){
                return mid;
            } else if (guess < x) {
                left = mid + 1;
            } else {
                right = mid -1;
            }
        }

        return right; 
        
    }
};
