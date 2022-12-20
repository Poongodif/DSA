/*
You are given a N X N integer matrix. You have to find the sum of all the minor diagonal elements of A.

Minor diagonal of a M X M matrix A is a collection of elements A[i, j] such that i + j = M + 1 (where i, j are 1-based).
*/

public class Solution {
    // DO NOT MODIFY THE ARGUMENTS WITH "final" PREFIX. IT IS READ ONLY
    public int solve(final int[][] A) {
        int sum = 0;
        int n=A.length;
        int m=A[0].length;
        for(int i=0; i<n; i++){
            for(int j=0; j<m; j++){
                if (i+j == m-1) sum+= A[i][j];
            }
        }
        return sum;
    }
}


