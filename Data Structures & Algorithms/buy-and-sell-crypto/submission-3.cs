public class Solution {
    public int MaxProfit(int[] prices) {
        int buy=prices[0];
        int max=0;
        for(int i=0;i<prices.Length;i++){
            if(prices[i]<buy){
                buy=prices[i];
            }
            else if(prices[i]-buy>max){
                max=prices[i]-buy;
            }
        }
        return max;
    }
}
