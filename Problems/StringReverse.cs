class Solution {
    public string solve(string A) {
        char[] chars = A.ToCharArray();
        Array.Reverse(chars);
        
        return new string(chars);
    }
}
