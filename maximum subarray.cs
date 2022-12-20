/*
You are given an integer array C of size A. Now you need to find a subarray (contiguous elements) so that the sum of contiguous elements is maximum.
But the sum must not exceed B.

*/

class Solution {
    public int maxSubarray(int A, int B, List<int> C) {
        int sum =0;
        int maxsum = 0;
        for(int i=0; i< C.Count(); i++){
            sum = 0;
            for(int j=i; j<C.Count(); j++){
                sum += C[j];
                if (maxsum <= B && sum <= B)
                maxsum = Math.Max(maxsum, sum);
                
            }
        }
        return maxsum;
    }
}

