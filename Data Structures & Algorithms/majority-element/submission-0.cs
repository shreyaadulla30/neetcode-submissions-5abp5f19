public class Solution {
    public int MajorityElement(int[] nums) {
        int n= nums.Length;
        if (n == 1) return nums[0];
        Dictionary<int,int> dict =new Dictionary<int,int>();
        foreach(int i in nums){
            if(dict.ContainsKey(i)){
                dict[i]++;
                if(dict[i]>n/2){
                    return i;
                }
            }
            else{
                dict[i]=1;
            }
        }
        return nums[0];
    }
}