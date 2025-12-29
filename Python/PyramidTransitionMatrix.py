class Solution(object):
    def pyramidTransition(self, bottom, allowed):
        """
        :type bottom: str
        :type allowed: List[str]
        :rtype: bool
        """
        tops = defaultdict(set)
        for tri in allowed:
            tops[tri[:2]].add(tri[2])

        memo = {}

        def can_build(row):
            if len(row) == 1:
                return True
            if row in memo:
                return memo[row]

            for i in range(len(row)-1):
                if row[i:i+2] not in tops:
                    memo[row] = False
                    return False

            #Backtracking
            def build_next(i, next_row):
                if i == len(row) - 1:
                    return can_build(next_row)

                pair = row[i:i+2]
                for c in tops[pair]:
                    if build_next(i + 1, next_row + c):
                        return True
                return False

            memo[row] = build_next(0, "")
            return memo[row]

        return can_build(bottom)
        
