/*
Problem Description

You are given two integer matrices A and B having same size(Both having same number of rows (N) and columns (M). You have to subtract matrix B from A and return the resultant matrix. (i.e. return the matrix A - B).

If A and B are two matrices of the same order (same dimensions). Then A - B is a matrix of the same order as A and B and its elements are obtained by doing an element wise subtraction of A from B.
*/

public class Solution {
    public int[][] solve(int[][] A, int[][] B) {
       for(int i = 0; i< A.length; i++){
            for(int j=0; j < A[0].length; j++){
                A[i][j] -= B[i][j];
            }
        }
        return A;
    }
}


