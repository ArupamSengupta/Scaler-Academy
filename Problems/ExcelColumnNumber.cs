class Solution {
    public int titleToNumber(string A) {
        int titleNum = 0;
        int powIndex = 0;
        
        for (int index=A.Length-1; index>=0; index--){
            titleNum += (A[index] - 'A' + 1)*Convert.ToInt32(Math.Pow(26, powIndex));
            powIndex++;
        }
        
        return titleNum;
    }
}
