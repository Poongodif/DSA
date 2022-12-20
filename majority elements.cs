/*
Problem Description
Given an array of size N, find the majority element. The majority element is the element that appears more than floor(n/2) times.
You may assume that the array is non-empty and the majority element always exists in the array.



Problem Constraints
1 <= N <= 5*105
1 <= num[i] <= 109
*/

class Solution {
    public int majorityElement(List<int> A) {
        int ele = A[0]; int freq = 0;
            for(int i = 1; i< A.Count(); i++)
            {
                if (freq == 0)
                {
                    ele = A[i];
                    freq = 1;
                }
                else if (ele != A[i])
                {
                    freq--;
                }
                else freq++;
            }
            int cnt = 0;
            for(int j=0; j< A.Count(); j++)
            {
                if (ele == A[j]) cnt++;
            }
            if (cnt > A.Count() / 2) return ele;
            else return -1;

    }
}


