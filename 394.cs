public class Solution {
    public string DecodeString(string s) {
        var stack = new Stack<string>();
        var currentString = new StringBuilder();
        var currentNumber = 0;

        foreach (var ch in s) {
            if (char.IsDigit(ch)) {
                currentNumber = currentNumber * 10 + (ch - '0');
            } else if (ch == '[') {
                stack.Push(currentString.ToString());
                stack.Push(currentNumber.ToString());
                currentString.Clear();
                currentNumber = 0;
            } else if (ch == ']') {
                var repeatedTimes = int.Parse(stack.Pop());
                var previousString = stack.Pop();

                var decodedString = new StringBuilder(previousString);
                for (var i = 0; i < repeatedTimes; i++) {
                    decodedString.Append(currentString);
                }

                currentString = decodedString;
            } else {
                
                currentString.Append(ch);
            }
        }

        return currentString.ToString();
    }}
