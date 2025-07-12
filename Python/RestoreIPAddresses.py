class Solution(object):
    def restoreIpAddresses(self, s):
        """
        :type s: str
        :rtype: List[str]
        """
        res =[]

        def is_valid(segment):
            if len(segment) > 1 and segment[0] == '0':
                return False
            return 0 <= int(segment) <= 255

        def backtrack(start=0, path=[]):
            if len(path) == 4:
                if start == len(s):
                    res.append(".".join(path))
                return

            for length in range(1, 4):
                if start + length > len(s):
                    break
                segment = s[start:start+length]
                if is_valid(segment):
                    backtrack(start + length, path + [segment])

        backtrack()
        return res
