class Solution {
    public List<string> fizzBuzz(int A) {
        List<string> fizzBuzzArr = new List<string>();
        for (int index=1; index<=A; index++){
            
            if (index%15 == 0){
                fizzBuzzArr.Add("FizzBuzz");
            } else if (index%5 == 0){
                fizzBuzzArr.Add("Buzz");
            } else if (index%3 == 0){
                fizzBuzzArr.Add("Fizz");
            } else {
                fizzBuzzArr.Add(index.ToString());
            }
        }
        
        return fizzBuzzArr;
    }
}
