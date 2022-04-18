class Solution {
    public int solve(int A) {
        
        int sumOfDigit=0;
        while (A>0){
            sumOfDigit += A%10;
            A/=10;
        }
        
        return sumOfDigit;
    }
}
