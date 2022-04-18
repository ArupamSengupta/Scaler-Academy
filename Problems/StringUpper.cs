class Solution {
    public List<char> to_upper(List<char> A) {
        string str = new string(A.ToArray());
        
        string upperStr = str.ToUpper();
        
        return upperStr.ToList();
    }
}
