public class Solution {
    public long RepairCars(int[] ranks, int cars) {
        Array.Sort(ranks);
        long left = 1;
      
        long right = (long)ranks[0]*cars*cars;

        while(left<right){
            long mid = left + (right - left) / 2;
            if(CanRepairInTime(ranks,cars,mid)){
                right = mid;
            
            }
            else{
                left = mid+1;
            }
        }
        return left;
        
    }
    public static bool CanRepairInTime(int[] ranks, int cars, long maxTime){
        long totalCars =0;
        foreach(var r in ranks){
             long maxCars = (long)Math.Sqrt(maxTime / r); 
            totalCars += maxCars;
            if (totalCars >= cars) return true; 
        }
        return false;
    }
}
