/*
You will be given an integer n. You need to return the count of prime numbers less than or equal to n.
*/

class Solution {
    public int solve(int A) {
        int count = 0;
        for (int i = 2; i <= A; i++){
            if (isPrime(i) == true) {
                count = count +1;
            }
        }
        return count;

    }

static bool isPrime(int n) {
    if (n <= 1) return false;
    if (n <= 3) return true;

    if (n%2 == 0 || n%3 == 0){
        return false;
    }

    for (int i = 5; i*i <= n; i = i+6){
        if (n%i == 0 || n % (i+2) == 0 )  return false;
    }
   return true;
}

}
