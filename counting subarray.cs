/*
Given an array A of N non-negative numbers and a non-negative number B,
you need to find the number of subarrays in A with a sum less than B.
We may assume that there is no overflow.
*/

class Solution {
    public int solve(List<int> A, int B) {
        int sum =0;
        int cnt = 0;       
        for(int i=0; i< A.Count(); i++){
            sum = 0;
            for(int j=i; j<A.Count(); j++){
                sum=0;
                for(int k=i; k<= j; k++){
                    sum += A[k];
                    }
                if (sum <B) cnt++;                
            }
        }
        return cnt;
    }
}



