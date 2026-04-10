public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int n=nums.Length;
        int k=1,c=0;
        for(int i=1;i<n;i++){
            if(nums[i]!=nums[i-1]){
                nums[k]=nums[i];
                k++;
            }
            
        }
        return k;
    }
}