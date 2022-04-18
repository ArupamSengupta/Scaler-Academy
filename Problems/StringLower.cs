class Solution {
    public List<char> to_lower(List<char> A) {
        string str = new string(A.ToArray());
        
        string lowerStr = str.ToLower();
        
        return lowerStr.ToList();
    }
}