/*
Given an array A of length N, return the subarray from B to C.



*/

class Solution {
    public List<int> solve(List<int> A, int B, int C) {
        List<int> subarr = new List<int>();
        for(int i=B; i<=C; i++){
            subarr.Add(A[i]);
        }
        return subarr;
    }
}

}

}
