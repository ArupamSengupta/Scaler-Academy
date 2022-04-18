class Solution {
    public List<List<int>> solve(int A) {
        
        List<List<int>> solution = new List<List<int>>();
        
        for (int index=0; index<A; index++){
            List<int> row = new List<int>();
            for (int zeroCount=A - 1; zeroCount>index; zeroCount--){
                row.Add(0);
            }
            
            for (int eleCount=index+1; eleCount>0; eleCount--){
                row.Add(eleCount);
            }
            
            solution.Add(row);
        }
        
        return solution;
    }
}
