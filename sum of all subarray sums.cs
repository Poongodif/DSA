/*
You are given an integer array A of length N.
You have to find the sum of all subarray sums of A.
More formally, a subarray is defined as a contiguous part of an array which we can obtain by deleting zero or more elements from either end of the array.
A subarray sum denotes the sum of all the elements of that subarray.
*/

class Solution {
    public long subarraySum(List<int> A) {
        long sum=0; long totsum =0;
        for(int i=0; i<A.Count(); i++){
            sum = 0;
            for(int j=i; j<A.Count(); j++){
                sum += A[j];
                totsum += sum;
            }
        }
        return totsum;
    }
}
