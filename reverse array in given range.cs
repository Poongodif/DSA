/*
Given an array A of N integers. Also given are two integers B and C. Reverse the array A in the given range [B, C]

Problem Constraints
1 <= N <= 105
1 <= A[i] <= 109
0 <= B <= C <= N - 1
*/

class Solution {
    public List<int> solve(List<int> A, int B, int C) {
        int i=B; int j=C; int swapx =0; int swapy=0;
        while (i <= j){
            swapx = A[i];
            swapy = A[j];
            A[i] = swapy;
            A[j] = swapx;
            i++; j--;
        }
        return A;
    }
}
