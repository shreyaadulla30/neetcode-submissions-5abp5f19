public class Solution {
    public void ReverseString(char[] s) {
        int n=s.Length;
       int left =0;
       int right=n-1;
       while(left<right){
        char temp = s[left];
        s[left]=s[right];
        s[right]=temp;
        right--;
        left++;
       }
        
    }
}