/*
A wire connects N light bulbs.

Each bulb has a switch associated with it; however, due to faulty wiring, a switch also changes the state of all the bulbs to the right of the current bulb.

Given an initial state of all bulbs, find the minimum number of switches you have to press to turn on all the bulbs.

You can press the same switch multiple times.

Note: 0 represents the bulb is off and 1 represents the bulb is on.

*/

class Solution {
    public int bulbs(List<int> A) {
        int cnt = 0; int state = 0;
        for(int i=0; i< A.Count(); i++){
            if(A[i] == state){
                state = 1 - state; 
                cnt++;
            }
        }
        return cnt;
    }

}


}
