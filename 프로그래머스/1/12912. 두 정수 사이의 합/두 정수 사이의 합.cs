public class Solution {
    public long solution(int a, int b) {
        int min, max;
        if (a > b) {
            min = b;
            max = a;
        } else {
            min = a;
            max = b;
        }
        long result = min;
        for (int i = min+1; i < max + 1; i++) result = result + i;
        return result;
    }
}
