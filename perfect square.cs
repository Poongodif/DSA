/*
Given a number A. Return square root of the number if it is perfect square otherwise return -1
*/

class Solution {
    public int solve(int A) {
        int i =1; int ans = 0;
        while (i*i <= A){
           ans = i; i++;
       }
       if (ans * ans == A) return ans;
       else   return -1;
       }        
    }