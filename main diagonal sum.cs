/*
You are given a N X N integer matrix. You have to find the sum of all the main diagonal elements of A.

Main diagonal of a matrix A is a collection of elements A[i, j] such that i = j.
*/

public class Solution {
    // DO NOT MODIFY THE ARGUMENTS WITH "final" PREFIX. IT IS READ ONLY
    public int solve(final int[][] A) {
        int sum = 0;
        for(int i=0; i<A.length; i++){
            for(int j=0; j<A[0].length; j++){
                if(i==j) sum += A[i][j];
            }
        }
        return sum;
    }
}


