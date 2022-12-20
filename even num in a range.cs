/*
You are given an array A of length N and Q queries given by the 2D array B of size Q*2. Each query consists of two integers B[i][0] and B[i][1].
For every query, the task is to find the count of even numbers in the range A[B[i][0]…B[i][1]].
*/

class Solution {
    public List<int> solve(List<int> A, List<List<int>> B) {
      List<int> even = new List<int>();
      int cnt = 0;
            foreach(List<int> C in B){
                cnt = 0;
                for(int i= C[0]; i<=C[1]; i++){
                    if(A[i] % 2 == 0) cnt ++;
                }
                even.Add(cnt);
            }
        return even;
    }
}





