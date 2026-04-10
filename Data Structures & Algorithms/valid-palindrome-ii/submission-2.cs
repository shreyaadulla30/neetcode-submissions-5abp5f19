public class Solution {
    public bool ValidPalindrome(string s) {
        int i = 0, j = s.Length - 1;

        while (i < j) {
            if (s[i] != s[j]) {
                // Try skipping either left or right character
                return IsPalindrome(s, i + 1, j) || IsPalindrome(s, i, j - 1);
            }
            i++;
            j--;
        }
        return true;
    }

    private bool IsPalindrome(string s, int left, int right) {
        while (left < right) {
            if (s[left] != s[right]) {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}