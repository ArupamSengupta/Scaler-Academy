class Solution {
    public int solve(List<int> A, int B) {
        int isGood = 0;
        
        for (int i=0; i<A.Count; i++){
            for (int j=i+1; j<A.Count; j++){
                if (A[i] + A[j] == B)
                    isGood = 1;
            }
        }
        
        return isGood;
    }
}
