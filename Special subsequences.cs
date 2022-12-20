/*
You have given a string A having Uppercase English letters.

You have to find how many times subsequence "AG" is there in the given string.

NOTE: Return the answer modulo 109 + 7 as the answer can be very large.


*/

class Solution {
    public int solve(string A) {
        int c=0;
        for(int i=0; i<A.Length; i++){
            if(A[i] == 'A'){
                for(int j = i+1; j<A.Length; j++){
                    if(A[j] == 'G'){
                        c++;
                    }
                }
            }
        }
        return c;
    }
}
