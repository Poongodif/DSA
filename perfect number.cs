/*
You are given an integer A. You have to tell whether it is a perfect number or not.

Perfect number is a positive integer which is equal to the sum of its proper positive divisors.

A proper divisor of a natural number is the divisor that is strictly less than the number.
*/

class Solution {
    public int solve(int A) {

        int divisor = 1;
        for (int i = 2; i*i <= A; i++){
            if (A%i == 0) {
                if (i*i != A) {
                    divisor = divisor + i + A/i;
                }
                else {
                    divisor = divisor + i;
                }
               
            }
        }
     if (divisor == A && A!= 1) {
         return 1;
     }
     else{
         return 0;
     }

    }
}