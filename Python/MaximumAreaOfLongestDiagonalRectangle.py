class Solution(object):
    def areaOfMaxDiagonal(self, dimensions):
        """
        :type dimensions: List[List[int]]
        :rtype: int
        """
        one_diagsq = -1
        one_area = 0
        for l, w in dimensions:
            diagsq = l*l + w*w
            area = l*w
            if diagsq > one_diagsq or (diagsq == one_diagsq and area > one_area):
                one_diagsq = diagsq
                one_area = area
        return one_area
        
