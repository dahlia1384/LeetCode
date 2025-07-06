class Solution {
public:
    vector<vector<string>> solveNQueens(int n) {
        vector <vector<string>> result;
        vector <string> board(n, string(n, '.'));
        vector <bool> cols(n, false);
        vector <bool> diag1(2 * n - 1, false);
        vector <bool> diag2(2 * n - 1, false);
        backtrack (0, n, board, result, cols, diag1, diag2);
        return result;
        
    }

    private:
        void backtrack(int row, int n, vector<string>& board, vector<vector<string>>& result, vector<bool>& cols, vector<bool>& diag1, vector<bool>& diag2){
            if (row == n){
                result.push_back(board);
                return;
            }

            for (int col = 0; col < n; ++col){
                if (cols[col] || diag1[row-col + n- 1] || diag2[row + col])
                    continue;

                    //THE QUEENS TIME TO SHINE !!!!!!!
                    board [row][col] = 'Q';
                    cols[col] = diag1[row - col + n -1] = diag2[row + col] = true;

                    backtrack(row + 1,n,board,result, cols, diag1, diag2);

                    //Now the Queen is gone :( (using backtracking of course)
                    board[row][col] = '.';
                    cols[col] = diag1[row - col + n -1] = diag2[row + col] = false;
            }
        }
};
