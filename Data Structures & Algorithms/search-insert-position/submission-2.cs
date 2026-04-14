public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int low = 0;
        int mid=0;
    int high =nums.Length - 1;
    while (low <= high) {
        mid=low + (high - low) / 2;
        if (nums[mid] == target)
            return mid;

        if (nums[mid] < target)
            low = mid + 1;

        else
            high = mid - 1;
    }

    if(target < nums[mid]){
        return mid;
    }
    else{
        return mid+1;
    }
    }
}