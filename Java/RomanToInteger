import java.util.*;

class Solution {
    public int romanToInt(String s) {

        // Creating a hash map to store Roman symbols and their corresponding values
        HashMap<Character, Integer> romanMap = new HashMap<>();
        romanMap.put('I', 1);
        romanMap.put('V', 5);
        romanMap.put('X', 10);
        romanMap.put('L', 50);
        romanMap.put('C', 100);
        romanMap.put('D', 500);
        romanMap.put('M', 1000);

        int total = 0;
        int prevValue = 0;

        // Traverse from left to right
        for (int i = 0; i < s.length(); i++) {
            int currentValue = romanMap.get(s.charAt(i));

            // If the current value is less than the previous one, subtract the previous
            // This requires looking at the relationship between current and previous
            if (currentValue > prevValue) {
                // Undo the last addition and add the correct difference
                total += (currentValue - 2 * prevValue);
            } else {
                total += currentValue;
            }

            prevValue = currentValue;
        }

        return total;
    }

    // Main method to test
    public static void main(String[] args) {
        Solution solution = new Solution();
        System.out.println(solution.romanToInt("III"));     
        System.out.println(solution.romanToInt("LVIII"));   
        System.out.println(solution.romanToInt("MCMXCIV")); 
    }
}
