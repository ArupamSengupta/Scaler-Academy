class Solution {
    public int isPalindrome(int A) {
        if (A<0){
            return 0;
        } else {
            return (A == reverse(A))?1:0;
        }
    }
    
    public int reverse(int num){
        int revNum = 0;
        
        while(num>0){
            int rem = num % 10;  
            revNum = (revNum * 10) + rem;  
            num /= 10;
        }
        
        return revNum;
    }
}
