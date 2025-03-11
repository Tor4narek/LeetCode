public class Solution {
    public string GcdOfStrings(string str1, string str2) {
        if ((str1 + str2) != (str2 + str1)) {
            return "";
        }
        int gcdLength = Gcd(str1.Length, str2.Length);
        return str1.Substring(0, gcdLength);
    }

    private int Gcd(int a, int b) {
        return b == 0 ? a : Gcd(b, a % b);
    }
}
