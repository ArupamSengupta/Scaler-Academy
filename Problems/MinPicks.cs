class Solution {
    public int solve(List<int> A) {
        
        int maxEven, minOdd;
        maxEven = Int32.MinValue;
        minOdd = Int32.MaxValue;
        
        for (int index=0; index<A.Count; index++){
            if (EvenOrOdd(A[index]) == 1){
                if (A[index] > maxEven)
                    maxEven = A[index];
            } else {
                if (A[index] < minOdd)
                    minOdd = A[index];
            }
        }
        
        return maxEven - minOdd;
    }
    
    public int EvenOrOdd(int num){
        return num%2 == 0 ? 1 : 0;
    }
}
