class Solution(object):
    def solveSudoku(self, board):
        """
        :type board: List[List[str]]
        :rtype: None Do not return anything, modify board in-place instead.
        """
        self.board = board
        self.rows = [set(str(d) for d in range(1, 10)) for _ in range(9)]
        self.cols = [set(str(d) for d in range(1, 10)) for _ in range(9)]
        self.boxes = [set(str(d) for d in range(1, 10)) for _ in range(9)]

        # Initialize the sets by removing used digits
        for r in range(9):
            for c in range(9):
                val = board[r][c]
                if val != '.':
                    self.rows[r].remove(val)
                    self.cols[c].remove(val)
                    self.boxes[(r // 3) * 3 + c // 3].remove(val)

        self.backtrack()
    
    def backtrack(self):
        # Find cell with fewest possibilities (MRV heuristic)
        min_cell = None
        for r in range(9):
            for c in range(9):
                if self.board[r][c] == '.':
                    box_idx = (r // 3) * 3 + c // 3
                    possible = self.rows[r] & self.cols[c] & self.boxes[box_idx]
                    if len(possible) == 0:
                        return False
                    if len(possible) == 1:
                        min_cell = (r, c, possible)
                        break
            if min_cell:
                break
        if not min_cell:
            # No MRV cell found => find any empty cell
            for r in range(9):
                for c in range(9):
                    if self.board[r][c] == '.':
                        min_cell = (r, c)
                        break
                if min_cell:
                    break
            else:
                return True  # Board is full

        r, c = min_cell[:2]
        box_idx = (r // 3) * 3 + c // 3

        # Try all valid values
        for num in list(self.rows[r] & self.cols[c] & self.boxes[box_idx]):
            self.board[r][c] = num
            self.rows[r].remove(num)
            self.cols[c].remove(num)
            self.boxes[box_idx].remove(num)

            if self.backtrack():
                return True

            # Backtrack
            self.board[r][c] = '.'
            self.rows[r].add(num)
            self.cols[c].add(num)
            self.boxes[box_idx].add(num)

        return False
    
