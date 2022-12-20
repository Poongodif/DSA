/*
Given an array A of N integers. Count the number of elements that have at least 1 elements greater than itself.

1 <= N <= 105
1 <= A[i] <= 109
*/

class Solution {
    public int solve(List<int> A) {
        int maxnum = int.MinValue; 
        int cnt =0;
        for (int i =0; i<=A.Count()-1; i++){
            if (maxnum < A[i]) {
                maxnum = A[i];
            }
        }

        for (int j=0; j<=A.Count()-1; j++){
            if (maxnum == A[j]){
                cnt +=1;
            }
        }

        return A.Count - cnt;
    }
}
