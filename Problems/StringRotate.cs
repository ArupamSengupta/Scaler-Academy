class Solution {
    public string solve(string A, int B) {
        
        string result = "";
        if (B == A.Length){
            result = A;
        } else {
            B = B % A.Length;
            result = A.Substring(A.Length - B) + A.Substring(0, A.Length - B);
        }
        
        return result;
    }
}
