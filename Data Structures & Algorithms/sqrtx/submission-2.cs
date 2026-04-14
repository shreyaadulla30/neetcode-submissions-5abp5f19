public class Solution {
    public int MySqrt(int x) {
        if(x<2){
            return x;
        }
        int ans=0,left=1,right=x/2;
        while(left<=right){
            int mid=left+(right-left)/2;
            long sq=(long)mid*mid;
            if(sq==x){ return mid;}
            else if(sq< x){
                ans=mid;
                left=mid+1;
            }
            else{
                right =mid-1;
            }
        }
        return ans;
    }
}