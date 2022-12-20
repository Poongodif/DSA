/*
Problem Description
You are given two matrices A & B of same size, you have to return another matrix which is the sum of A and B.
*/

public class Solution {
    public int[][] solve(int[][] A, int[][] B) {
       for(int i = 0; i< A.length; i++){
            for(int j=0; j < A[0].length; j++){
                A[i][j] += B[i][j];
            }
        }
        return A;
    }
}


