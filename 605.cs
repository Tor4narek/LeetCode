public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
    var l = flowerbed.Length;
    var sum = 0;
    if(l>1){
             if(flowerbed[0]==0 && flowerbed[1]==0){
        sum+=1;
        flowerbed[0]=1;
    }
    if(flowerbed[l-1]==0 && flowerbed[l-2]==0){
        sum+=1;
        flowerbed[l-1]=1;
    }
    for(var i =1;i<l-1;i++){
                if(flowerbed[i-1]==0 && flowerbed[i+1]==0 && flowerbed[i]!=1){
                    sum+=1;
                    flowerbed[i]=1;
                }
       } 
         return sum>=n;
    }
    if(flowerbed[0]==0){
        return true;

    }
    if(n==0){
        return true;
    }
    return false;
    
       
      
       
       

       
   
 
    }
}
