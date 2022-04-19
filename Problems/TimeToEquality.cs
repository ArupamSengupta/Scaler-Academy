class Solution {
    public int solve(List<int> A) {
        int maxNum = findMax(A);
        int minTime = 0;
        
        for (var index=0;index<A.Count; index++){
            minTime += (maxNum - A[index]);
        }
        
        return minTime;
    }
    
    public int findMax(List<int> Arr) {
        int maxEle = Arr[0];
        
        for (var index=1; index<Arr.Count; index++) {
            if (Arr[index]> maxEle){
                maxEle = Arr[index];
            }
        }
        
        return maxEle;
    }
}