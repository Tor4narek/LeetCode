public class Solution {
     public int Compress(char[] chars) {
        if (chars.Length == 0) return 0; 
    
        int lastNewChar = 0; 
        int letCounter = 1;   
        char let = chars[0];

        for (int i = 1; i < chars.Length; i++) {
            if (let != chars[i]) {
                chars[lastNewChar] = let;
                lastNewChar++;
                if (letCounter > 1) {
                    foreach (var digit in letCounter.ToString()) {
                        chars[lastNewChar] = digit;
                        lastNewChar++;
                    }
                }
                let = chars[i];
                letCounter = 1;
            } else {
                letCounter++;
            }
        }
        
        chars[lastNewChar] = let;
        lastNewChar++;
        if (letCounter > 1) {
            foreach (var digit in letCounter.ToString()) {
                chars[lastNewChar] = digit;
                lastNewChar++;
            }
        }

        return lastNewChar; 
    }
}
