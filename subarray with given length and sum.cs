/*
Problem Description
Given an array A of length N. Also given are integers B and C.

Return 1 if there exists a subarray with length B having sum C and 0 otherwise
*/

public class Solution {
    public int solve(int[] A, int B, int C) {
        int s = 0; int e = B-1;
        int sum = 0; int ret = 0;
        for(int i = 0; i< A.length; i++){
            s = i; e = i+B; sum = 0;
           while(s<e && e <= A.length){
              sum += A[s];
              s++; 
           }
           if(sum == C) {ret = 1; break;}
        }
        return ret;
    }
}



