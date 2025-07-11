class Solution(object):
    def climbStairs(self, n):
        """
        :type n: int
        :rtype: int
        """
        if n <= 2:
            return n

        prev, curr = 1,2
        for _ in range (3,n+1):
            prev, curr = curr, prev + curr

        return curr

        #Problem solved using the Fibonacci Approach
