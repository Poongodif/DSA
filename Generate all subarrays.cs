/*
You are given an array A of N integers.
Return a 2D array consisting of all the subarrays of the array
*/

class Solution {
    public List<List<int>> solve(List<int> A) {
        List<List<int>> subarr = new List<List<int>>();
        for(int i =0; i<A.Count(); i++){
            for(int j=i; j<A.Count(); j++){
                List<int> arr = new List<int>();
                for(int k=i; k<=j; k++){
                    arr.Add(A[k]);                
                }
                subarr.Add(arr);
            }
        }
        return subarr;
    }
}


