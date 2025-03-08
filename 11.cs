public class Solution {
   public int MaxArea(int[] height) {
            var maxArea = 0;
            var ln = height.Length;
            var i = 0;
            var j = ln-1;
           while(i<j){
               
                    var min = height[i]<height[j]?height[i]:height[j];
                    var area = 0;
                    area = min*(j-i);
                    if(area>=maxArea){
                        maxArea=area;
                    }
                    if(height[i]<height[j])
                    {
                        i++;
                    }
                    else
                    {
                        j--;
                    } 
            }
            return maxArea;
        }}
