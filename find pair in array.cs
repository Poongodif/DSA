/*
Problem Description
Given an array A and an integer B. A pair(i, j) in the array is a good pair if i != j and (A[i] + A[j] == B). Check if any good pair exist or not.

Problem Constraints
1 <= A.size() <= 104

1 <= A[i] <= 109

1 <= B <= 109
*/

class Solution {
    public int solve(List<int> A, int B) {
        int pair = 0;
        for (int i=0; i <= A.Count-1; i++){
            for(int j = A.Count -1; j >= 0; j-- ){
                if (i < j){
                    if (A[i] + A[j] == B) {
                        pair += 1;
                    }
                }
            }
        }
        if (pair > 0)
        return 1;
        else 
        return 0;
    }
}
