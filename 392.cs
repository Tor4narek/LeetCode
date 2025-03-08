public class Solution {
public bool IsSubsequence(string s, string t) {
    int indexS = 0;
    for (int i = 0; i < t.Length; i++) {
        if (indexS < s.Length && t[i] == s[indexS]) {
            indexS++;
        }
    }
    return indexS == s.Length;
}

}
