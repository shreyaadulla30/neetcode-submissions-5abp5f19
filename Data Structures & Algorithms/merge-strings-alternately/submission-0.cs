public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int l1=word1.Length;
        int l2=word2.Length;
        StringBuilder sb= new StringBuilder();
        int i=0;int j=0;
        while(i<l1 && j<l2){
            sb.Append(word1[i]);
            sb.Append(word2[j]);
            i++;
            j++;
        }
        if(l1>l2){
            for(int k=l2;k<l1;k++){
                sb.Append(word1[k]);
            }
        }
        else{
            for(int k=l1;k<l2;k++){
                sb.Append(word2[k]);
            }
        }
        return sb.ToString();
    }
}