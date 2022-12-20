/*
Given an integer array A of size N and an integer B, you have to return the same array after rotating it B times towards the right.

Problem Constraints
1 <= N <= 105
1 <= A[i] <=109
1 <= B <= 109


*/

class Solution {
    public List<int> solve(List<int> A, int B) {
        if (B > A.Count()) B = B % A.Count();
        if(B != 0){
           A = SwapArray (A, 0, A.Count()-1);
           A = SwapArray (A, 0, B-1);
           A = SwapArray (A, B, A.Count()-1);
        }
        return A;
    }
    static  List<int> SwapArray(List<int> C, int x, int y){
            int i = x;  int j= y;           
            for (i=x; i< y; i++){
                if (i < j){
                int temp = 0;
                temp = C[j];
                C[j] = C[i];
                C[i] = temp;
                j--;
                }
            }
            return C;
        }

   
}
