using System;
using System.Collections.Generic;

public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        var stack = new Stack<int>();
        
        foreach (var asteroid in asteroids) {
            bool destroyed = false;
            while (stack.Count > 0 && stack.Peek() > 0 && asteroid < 0) {
                if (stack.Peek() + asteroid == 0) {
                    stack.Pop(); 
                    destroyed = true;
                    break;
                } else if (stack.Peek() + asteroid < 0) {
                    stack.Pop(); 
                } else {
                    destroyed = true; 
                    break;
                }
            }
            if (!destroyed) {
                stack.Push(asteroid);
            }
        }
        var result = stack.ToArray();
        Array.Reverse(result);
        return result;
    }
}
