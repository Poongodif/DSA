/*
Given two integers A and B. A represents the count of mangoes and B represent the count of slices of mangoes. Mango can be cut into three slices of mangoes. A glass of mango shake can be formed by two slices of mangoes.

Find the maximum number of glasses of mango shakes you can make with A mangoes and B slices of mangoes initially.
*/

class Solution {
    public int solve(int A, int B) {
        int shake = 0;
        if (A > 0)
        shake = ((A * 3)+B) / 2;
        return shake; 
    }
}