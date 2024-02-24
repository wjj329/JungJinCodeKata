using System;
using System.Text; // StringBuilder를 사용하기 위해 필요

class Program
{
    static void Main(string[] args)
    {
        // 테스트 케이스 T
        int T = int.Parse(Console.ReadLine());

        // StringBuilder 인스턴스 생성
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < T; i++)
        {

            string[] ab = Console.ReadLine().Split();
            int a = int.Parse(ab[0]);
            int b = int.Parse(ab[1]);

            // 결과를 StringBuilder에 추가
            sb.AppendLine((a + b).ToString());
        }

        // 최종 결과 출력
        Console.Write(sb.ToString());
    }
}