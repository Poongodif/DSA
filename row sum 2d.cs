/*
You are given a 2D integer matrix A, return a 1D integer array containing row-wise sums of original matrix.
*/

public class Solution {
    public int[] solve(int[][] A) {
        int[] sumArr = new int[A.length];
        int sum=0;
        for(int i=0; i<A.length; i++){
            sum = 0;
            for(int j=0; j<A[0].length; j++){
                sum += A[i][j];
            }
            sumArr[i] = sum;
        }
        return sumArr;
    }
}


