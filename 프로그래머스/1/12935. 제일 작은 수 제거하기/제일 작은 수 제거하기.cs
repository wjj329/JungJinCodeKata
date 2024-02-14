using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] solution(int[] arr) {
        List<int> arr_list = new List<int>(arr);
        int min = arr.Min();
        arr_list.RemoveAll(num => num == min);
        if(arr_list.Count ==0) { arr_list.Add(-1); }
        return arr_list.ToArray();
    }
}