class Solution {
    public int solve(string A) {
        return (A == revStr(A)) ? 1 : 0;
    }
    
    public string revStr(string A){
        char[] charStr = A.ToCharArray();
        Array.Reverse(charStr);
        
        return new string(charStr);
    }
}
