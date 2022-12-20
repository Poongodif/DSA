/*

/*You are given a constant array A.

You are required to return another array which is the reversed form of the input array.

Problem Constraints
1 <= A.size() <= 10000

1 <= A[i] <= 10000


*/

class Solution {
    public List<int> solve(List<int> A) {
        int j=A.Count()-1;
        for (int i=0; i<= A.Count()-1; i++){
            if (i < j){
            int temp = 0;
            temp = A[j];
            A[j] = A[i];
            A[i] = temp;
            j--;
            }
        }
        return A;
    }
}

