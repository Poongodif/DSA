/*
You are given a matrix A, you have to return another matrix which is the transpose of A.

NOTE: Transpose of a matrix A is defined as - AT[i][j] = A[j][i] ; Where 1 ≤ i ≤ col and 1 ≤ j ≤ row. The tranpose of a matrix switches the element at (i, j)th index to (j, i)th index, and the element at (j, i)th index to (i, j)th index.

*/

public class Solution {
    public int[][] solve(int[][] A) {
        int[][] Atrans = new int[A[0].length][A.length];
        int x=0, y=0;
        int n = A.length;
        int m = A[0].length;
        for(int j=0; j<A[0].length; j++){
            x=0; y=j;
            while(x < n && y >= 0)
            {
                Atrans[y][x] = A[x][y];
                x++;
                y--;
            }            
        }
        for(int i = 1; i<n; i++)
        {
            x=i; y = m-1;
            while(x < n && y >=0)
            {
                Atrans[y][x] = A[x][y];
                x++; y--;
            }
        }
        return Atrans;
    }
}
