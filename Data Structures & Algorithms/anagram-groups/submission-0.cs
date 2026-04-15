public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,List<string>> dict= new Dictionary<string,List<string>>();
        foreach(string s in strs){
            char[] chars = s.ToCharArray();
            Array.Sort(chars);
            string key = new string(chars);
            if(!dict.ContainsKey(key)){
                dict[key]= new List<string>();
            }
            dict[key].Add(s);
        }

        return dict.Values.ToList();
    }
}
