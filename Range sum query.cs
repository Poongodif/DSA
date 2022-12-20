/*
You are given an integer array A of length N.
You are also given a 2D integer array B with dimensions M x 2, where each row denotes a [L, R] query.
For each query, you have to find the sum of all elements from L to R indices in A (1 - indexed).
More formally, find A[L] + A[L + 1] + A[L + 2] +... + A[R - 1] + A[R] for each query.
*/

class Solution {
    public List<int> solve(List<int> A, List<List<int>> B) {
        for (int i =1; i< A.Count(); i++){
            A[i] += A[i-1];
        }
        List<int> sum = new List<int>();
        foreach(List<int> C in B){
            if(C[0] == 1)
                sum.Add(A[C[1]-1]);
            else
                sum.Add(A[C[1]-1] - A[C[0]-2]);
        }
        return sum;
    }
}

