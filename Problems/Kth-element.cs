class Solution {
    public int kthsmallest(List<int> A, int B) {
        A.Sort();
        return A[B-1];
    }
}
