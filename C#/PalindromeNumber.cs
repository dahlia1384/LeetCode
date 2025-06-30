public class Solution
{
    public bool IsPalindrome(int x)
    {

        //Doing what the follow up asks, solving without converting to a string\
        //This is done by initializing variable "reversedHalf" to hold half of the reserved #
        if (x < 0 || (x % 10 == 0 && x != 0)) return false;

        int reversedHalf = 0;

        //Reversing half of the number
        while (x > reversedHalf)
        {
            reversedHalf = reversedHalf * 10 + x % 10;
            x /= 10;
        }

        /* Even length: x == reversedHalf
           Odd length: x == reversedHalf / 10 */
        return x == reversedHalf || x == reversedHalf / 10;


    }
}
    