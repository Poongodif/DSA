/*
Given an array A of size N. You need to find the sum of Maximum and Minimum element in the given array.

Problem Constraints
1 <= N <= 105
-109 <= A[i] <= 109


*/

class Solution {
    public int solve(List<int> A) {
        int maxnum = int.MinValue; 
        int minum = A[0];
        int cnt =0;
        for (int i =0; i<=A.Count()-1; i++){
            if (maxnum < A[i]) {
                maxnum = A[i];
            }
        }

        for (int j=0; j<=A.Count()-1; j++){
            if (minum > A[j]){
                minum = A[j];
            }
        }

        return minum+maxnum;
    }
}

}
