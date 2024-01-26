using System;

public class Solution {
    public long solution(long n) {
        long answer = 0;
        double temp = Math.Sqrt(n);
        if(temp % 1 != 0)
        {
             return -1;
        }
        
        answer = ((long)temp + 1) * ((long)temp + 1);
        return answer;
    }
}