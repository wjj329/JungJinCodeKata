using System.Text;

public class Solution {
    public string solution(string s, int n) {

         StringBuilder sb = new StringBuilder();

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i]!=' ')
            {
                if (s[i] >= 65 && s[i]<=90)  //대문자 인경우
                {
                    if((char)(s[i] + n)<=90) //n을 더해도 대문자 범위를 넘지 않는 경우 
                    {
                        sb.Append((char)(s[i] + n));
                    }
                    else if((char)(s[i] + n) > 90) //대문자 범위인 90을 넘어버리는 경우
                    {
                        sb.Append((char)(s[i] -(26-n)));
                    }
                }
                else if (s[i] >= 97 && s[i]<=122)  //소문자인경우
                {
                    if ((char)(s[i] + n) <= 122)
                    {
                        sb.Append((char)(s[i] + n));
                    }
                    else if((char)(s[i] + n) > 122)
                    {
                        sb.Append((char)(s[i] - (26 - n)));
                    }
                }
            }
            else
            {
                sb.Append(' ');
            }
        }
        return sb.ToString();


    }
}