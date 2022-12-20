/*
Given a binary string A. It is allowed to do at most one swap between any 0 and 1. Find and return the length of the longest consecutive 1’s that can be achieved.


Input Format

The only argument given is string A.
Output Format

Return the length of the longest consecutive 1’s that can be achieved.
Constraints

1 <= length of string <= 1000000
A contains only characters 0 and 1.
*/

class Solution {
    public int solve(string A) {
        int ans = 0;
        int n = A.Length;
        int c= 0;
        for(int i=0; i < n; i++){
            c += Convert.ToInt32(A[i].ToString());
        }
        if(c == n) return n;
        for(int i=0; i<n; i++){
            int l=0, r=0;
            if(A[i].ToString() == "0"){
                for(int j = i-1; j >= 0; j--){
                    if(A[j].ToString() == "1") l++;
                    else break;
                }
                for(int j= i+1; j<n; j++){
                    if(A[j].ToString() == "1") r++;
                    else break;
                }
                if(l+r == c) {
                    ans = Math.Max(ans, l+r);
                }
                else{
                    ans = Math.Max(ans, l+r+1);
                }
            }
        }
        return ans;

    }
}



