/*
Given an array A and an integer B, find the number of occurrences of B in A.

Problem Constraints
1 <= B, Ai <= 109
1 <= |A| <= 105


*/

class Solution {
    public int solve(List<int> A, int B) {
        int cnt = 0;
        for (int i=0; i<=A.Count()-1; i++){
            if (B == A[i]){
                cnt +=1;
            }
        }
    return cnt;
    }
}
