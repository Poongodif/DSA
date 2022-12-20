/*
Problem Description
You are given a number A. You are also given a base B. A is a number on base B.
You are required to convert the number A into its corresponding value in decimal number system.


Problem Constraints
0 <= A <= 109
2 <= B <= 9

*/

class Solution {
    public int solve(int A, int B) {
        List<int> arr = new List<int>();
            while (A > 0)
            {
                arr.Add(A % 10);
                A = A / 10;
            }
            int ans = 0;
            for (int i = 0; i < arr.Count(); i++)
            {
                int temp = 0;
                if (i == 0) temp = arr[i] * 1;
                else if (i == 1) temp = arr[i] * B;
                else temp = Convert.ToInt32(arr[i] * Math.Pow(B, i));
                ans = ans + temp;
            }
        return ans;
    }
}

