class Solution(object):
    def exist(self, board, word):
        """
        :type board: List[List[str]]
        :type word: str
        :rtype: bool
        """
        if not board or not board[0]:
            return False
        m, n = len(board), len(board[0])
        from collections import Counter
        bc = Counter(ch for row in board for ch in row)
        wc = Counter(word)
        for ch, cnt in wc.items():
            if bc.get(ch, 0) < cnt:
                return False
        if bc.get(word[0], 0) > bc.get(word[-1], 0):
            word = word[::-1]
        def dfs(r, c, i):
            if i == len(word):
                return True
            if r < 0 or r >= m or c < 0 or c >= n or board[r][c] != word[i]:
                return False
            tmp = board[r][c]
            board[r][c] = "#"
            found = (dfs(r + 1, c, i + 1) or
                     dfs(r - 1, c, i + 1) or
                     dfs(r, c + 1, i + 1) or
                     dfs(r, c - 1, i + 1))
            board[r][c] = tmp
            return found
        first = word[0]
        for r in range(m):
            for c in range(n):
                if board[r][c] == first and dfs(r, c, 0):
                    return True
        return False
