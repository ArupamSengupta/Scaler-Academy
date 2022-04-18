class Solution {
    public int trailingZeroes(int A) {
        if (A < 0)
            return -1;
        
        int count=0;
        
        for (int index=5; A/index >= 1; index*= 5){
            count += A/index;
        }
        
        return count;
    }
}
