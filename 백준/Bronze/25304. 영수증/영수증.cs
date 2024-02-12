            int X = int.Parse(Console.ReadLine()); // 총 금액
            int N = int.Parse(Console.ReadLine()); // 물건 종류 수

            int total = 0;

            for (int i=0; i<N; i++)
            {
                string[] input = Console.ReadLine().Split( );
                int a = int.Parse(input[0]); //가격
                int b = int.Parse(input[1]); //개수

                total += a * b; // 총 금액에 물건의 가격과 개수를 곱한 값을 더함
            }

            if (total == X)
            {
                Console.WriteLine("Yes");
            }
            else { Console.WriteLine("No"); }