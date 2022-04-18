class Solution {
    public List<List<int>> solve(int A) {
        
        List<List<int>> solution = new List<List<int>>();
        
        for (int index=1; index<=A; index++){
            List<int> rows = new List<int>();
            for (int rowIndex=1; rowIndex<=index; rowIndex++){
                rows.Add(rowIndex);
            }
            
            solution.Add(rows);
        }
        
        return solution;
    }
}
