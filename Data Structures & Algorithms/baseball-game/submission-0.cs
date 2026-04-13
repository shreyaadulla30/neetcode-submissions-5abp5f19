public class Solution {
    public int CalPoints(string[] operations) {
        List<int> st=new List<int>();
        foreach(string op in operations){
            if(int.TryParse(op, out int num)){
                st.Add(num);
            }
            else if(op == "+"){
                st.Add(st[st.Count-1]+st[st.Count-2]);
            }
            else if(op == "D"){
                st.Add(st[st.Count-1]*2);
            }
            else if(op== "C"){
                st.RemoveAt(st.Count-1);
            }
        }
        int a=0;
        foreach(int num in st){
            a+=num;
        }
        return a;
    }
}