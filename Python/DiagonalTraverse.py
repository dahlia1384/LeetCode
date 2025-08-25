class Solution(object):
    def findDiagonalOrder(self, mat):
        """
        :type mat: List[List[int]]
        :rtype: List[int]
        """
        if not mat or not mat[0]:
            return []

        m,n = len(mat), len(mat[0])
        res = []
        i =j=0
        up = True 

        while len(res) < m*n:
            res.append(mat[i][j])
            if up:
                if j == n - 1:
                    i += 1
                    up = False
                elif i ==0:
                    j += 1
                    up = False
                else :
                    i -= 1
                    j += 1
            else :
                if i ==m -1:
                    j += 1
                    up = True
                elif j ==0:
                    i += 1
                    up = True
                else:
                    i += 1
                    j -= 1
        return res
        
