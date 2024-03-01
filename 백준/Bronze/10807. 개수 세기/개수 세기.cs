            int n = int.Parse(Console.ReadLine()); // 정수 개수 N
            string[] s = Console.ReadLine().Split(' '); // n개의 정수를 입력받아 배열로 저장
            int v = int.Parse(Console.ReadLine()); // 정수 v

            int cnt = 0; // v의 개수를 셀 변수
            for (int i = 0; i < n; i++)
            {
                if (int.Parse(s[i]) == v) cnt++;
            }
            Console.WriteLine(cnt);