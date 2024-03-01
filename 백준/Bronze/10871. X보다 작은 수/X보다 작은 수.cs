
using System;
using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            string[] q = Console.ReadLine().Split();

            StringBuilder answer = new StringBuilder();

            for (int i = 0; i < int.Parse(s[0]); i++)
            {
                // 정수 x보다 작은 숫자들을 검출
                if (int.Parse(s[1]) > int.Parse(q[i]))
                {
                    // 해당 숫자들을 answer에 공백과 함께 추가한다.
                    answer.Append(q[i] + " ");
                }
            }
            // 정답 출력
            Console.WriteLine(answer.ToString());
        }
    }
}


