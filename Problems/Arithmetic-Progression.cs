class Solution {
    public int solve(List<int> A) {
        A.Sort();
        int eleDiff = A[1] - A[0];
        int isArithProg = 1;
        
        for (int index=1; index<A.Count-1; index++){
            if ((A[index+1] - A[index]) != eleDiff)
                isArithProg = 0;
        }
        
        return isArithProg;
    }
}
