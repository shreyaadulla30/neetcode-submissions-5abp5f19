public class Solution {
    public bool hasDuplicate(int[] nums) {
        List<int> l=new List<int>();
        bool ans=false;
        for(int i=0;i<nums.Length;i++){
            if(l.Contains(nums[i])){
                ans=true;
            }
            else{
                l.Add(nums[i]);
            }
        } 
        return ans;
    }
}