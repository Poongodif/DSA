/*
Problem Description
You are given two matrices A & B of equal dimensions and you have to check whether two matrices are equal or not.

NOTE: Both matrices are equal if A[i][j] == B[i][j] for all i and j in the given range.
*/

public class Solution {
    public int solve(int[][] A, int[][] B) {
        int ret = 0;
        for(int i =0; i<A.length; i++){
            for(int j=0; j<A[0].length; j++){
                if(A[i][j] == B[i][j]){
                    ret = 1;
                }
                else if(A[i][j] != B[i][j])
                {
                   ret = 0;
                   break;
                }
                }
            }
        return ret;
    }
}


