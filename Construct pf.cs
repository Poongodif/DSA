/*
Given an array A of N integers. Construct prefix sum of the array in the given array itself.


*/

class Solution {
    public List<int> solve(List<int> A) {
        for(int i=1; i< A.Count(); i++){
            A[i] +=  A[i-1];
        }
        return A;
    }
}