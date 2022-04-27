class Solution {
    public int solve(string A) {
        int patternCount = 0;
        
        for (int index=0; index<A.Length-2; index++){
            string patternStr = A.Substring(index,3);
            
            if (patternStr == "bob"){
                patternCount++;
            }
        }
        
        return patternCount;
    }
}