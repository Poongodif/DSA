/*
You are given an integer array A. You have to find the second largest element/value in the array or report that no such element exists.

Problem Constraints
1 <= |A| <= 105

0 <= A[i] <= 109


*/

class Solution {
    public int solve(List<int> A) {
        int maxnum1 = int.MinValue; 
        int maxnum2 = int.MinValue;
        
        for (int i =0; i<=A.Count()-1; i++){
            if (A[i] > maxnum1) {
                maxnum2 = maxnum1;
                maxnum1 = A[i];
            }
 
           else if (A[i] > maxnum2 && A[i] != maxnum1)
                maxnum2 = A[i];
            
            }

            if (maxnum2 == int.MinValue) maxnum2 = -1;
             return maxnum2;    
        }
        
    
}
