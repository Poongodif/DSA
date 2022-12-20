/*
You are given an integer array A of length N.
You are also given a 2D integer array B with dimensions M x 2, where each row denotes a [L, R] query.
For each query, you have to find the sum of all elements from L to R indices in A (1 - indexed).
More formally, find A[L] + A[L + 1] + A[L + 2] +... + A[R - 1] + A[R] for each query.
*/

class Solution {
    public List<long> rangeSum(List<int> A, List<List<int>> B) {
        List<long> pfrange = new List<long>(); int cnt = 0;
        int N = A.Count();
        for(int i=1; i< N; i++){
            A[i] +=  A[i-1];
        }
        foreach(List<int> Q in B)
        {
            if(Q[0] == 1)
               pfrange.Add(A[Q[1]-1]);
            else
               pfrange.Add(A[Q[1]-1] - A[Q[0] -2]);
        }       
        return pfrange;
    }
}





