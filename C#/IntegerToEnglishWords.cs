public class Solution {
2    private static readonly string[] Below20 = {
3         "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine",
4        "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen",
5        "Seventeen", "Eighteen", "Nineteen"
6    };
7
8    private static readonly string[] Tens = {
9        "", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"
10    };
11
12    private static readonly string[] Thousands = { "", "Thousand", "Million", "Billion" };
13
14    public string NumberToWords(int num) {
15        if (num == 0) return "Zero";
16
17        string res = " ";
18        int i = 0;
19
20        while (num > 0) {
21            int part = num % 1000;
22            if (part != 0) {
23                string chunk = ConvertBelow1000(part).Trim();
24                string suffix = Thousands[i];
25                string cur = suffix == "" ? chunk : chunk + " " + suffix;
26                res = res == "" ? cur : cur + " " + res;
27
28            }
29
30            num /= 1000;
31            i++;
32        }
33
34        return res.Trim();
35        
36    }
37
38    private string ConvertBelow1000(int n){
39        if (n == 0) return "";
40        if (n < 20) return Below20[n] + " ";
41        if (n < 100) return Tens[n / 10] + " " + ConvertBelow1000(n % 10);
42        return Below20[ n / 100] + " Hundred " + ConvertBelow1000(n % 100);
43
44    }
45}
