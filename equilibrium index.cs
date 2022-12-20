/*
You are given an array A of integers of size N.

Your task is to find the equilibrium index of the given array

The equilibrium index of an array is an index such that the sum of elements at lower indexes is equal to the sum of elements at higher indexes.

NOTE:

Array indexing starts from 0.
If there is no equilibrium index then return -1.
If there are more than one equilibrium indexes then return the minimum index.


*/

class Solution {
    public int solve(List<int> A) {
        int cnt = -1; int left = 0; int right =0;
        for(int i=1; i< A.Count(); i++){
            A[i] +=  A[i-1];
        }
        int N = A.Count();
        for(int i=0; i< N; i++){
            if (i == 0)  { left = 0; }
            else { left = A[i-1]; }
            right = A[N-1] - A[i];
            if(left == right) {
                cnt = i;
                } 
        }
        return cnt;
               
    }
}
