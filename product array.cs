/*
Given an array of integers A, find and return the product array of the same size where the ith element of the product array will be equal to the product of all the elements divided by the ith element of the array.

Note: It is always possible to form the product array with integer (32 bit) values. Solve it without using the division operator.


*/

class Solution {
    public List<int> solve(List<int> A) {
        List<int> B = new List<int>();
        for (int i=0; i<A.Count(); i++){
            int prod = 1;
            for(int j=0; j<A.Count(); j++){
                if (i != j) prod = prod * A[j];
            }
            B.Add(prod);
        }
        return B;
    }
}


