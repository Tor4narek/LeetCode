public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
    List<bool> res = new List<bool>();
    var max =candies.Max();
    for(var i = 0; i<candies.Length;i++)
    {
        res.Add((candies[i] + extraCandies) >= max);
    }
    return res;
}
}
