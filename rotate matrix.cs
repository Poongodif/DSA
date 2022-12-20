/*
You are given a n x n 2D matrix A representing an image.

Rotate the image by 90 degrees (clockwise).

You need to do this in place.

Note: If you end up using an additional array, you will only receive partial score.

*/

public class Solution {
    public void solve(int[][] A) {
        int[][] Atrans = new int[A.length][A[0].length];
        for(int i=0; i< A.length; i++){
            for(int j=0; j< A[0].length; j++){
                Atrans[j][i] = A[i][j];
            }

        } 
        int m=A.length;
        for (int i=0; i< A.length; i++)
            {
                int s = 0; int e = m - 1;
                while (s < m/2)
                {
                    int temp = Atrans[i][s];
                    Atrans[i][s] = Atrans[i][e];
                    Atrans[i][e] = temp;
                    s++; e--; 
                }
            } 
            for(int i=0; i< A.length; i++){
            for(int j=0; j< A[0].length; j++){
                A[i][j] = Atrans[i][j];
            }

        }
    }
}
