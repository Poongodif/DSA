/*
Problem Description
You are given a matrix A and and an integer B, you have to perform scalar multiplication of matrix A with an integer B.


*/

public class Solution {
    public int[][] solve(int[][] A, int B) {
        for(int i = 0; i< A.length; i++){
            for(int j=0; j < A[0].length; j++){
                A[i][j] *= B;
            }
        }
        return A;
    }
}


