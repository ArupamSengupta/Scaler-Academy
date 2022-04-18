class Solution {
    public int solve(List<char> A) {
        for (var index=0; index<A.Count; index++){
            bool isAlphabet = isAlpha(A[index]);
            if (!isAlphabet){
                return 0;
            }
        }
        
        return 1;
    }
    
    public bool isAlpha(char ch){
        int asciiCode = (int)(ch);
        
        if ((asciiCode>=97 && asciiCode<=122) || (asciiCode>=65 && asciiCode<=90)){
            return true;
        } else {
            return false;
        }
    }
}
