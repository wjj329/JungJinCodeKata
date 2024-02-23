using System;
public class Solution {
    public string solution(string s) {
        char[] temp = s.ToCharArray();
        System.Array.Sort(temp);
        System.Array.Reverse(temp);
        string answer =new string(temp);
        return answer;
    }
}