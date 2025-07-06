//Two queens should never be attacking one another :(

class Solution {
public:
    int totalNQueens(int n) {
        int count = 0;
        std::vector<bool> cols(n,false);
        std::vector<bool> diag1(2 * n -1, false);
        std::vector<bool> diag2(2 * n-1, false);
        backtrack(0, n, cols, diag1, diag2, count);
        return count;

    }

    private:
        void backtrack(int row, int n, std::vector<bool>& cols, std::vector<bool>& diag1, std::vector<bool>& diag2, int& count){
            if(row == n){
                count++;
                return;
            }
        

            for (int col = 0; col < n; ++col ) {
                if (cols[col] || diag1[row - col + n - 1] || diag2[row + col])
                    continue;
                
                cols[col] = diag1[row - col + n - 1] = diag2[row + col] = true;
                backtrack(row + 1, n, cols, diag1, diag2, count);
                cols[col] = diag1[row - col + n -1] = diag2[row + col] = false;

            }
        }
};
