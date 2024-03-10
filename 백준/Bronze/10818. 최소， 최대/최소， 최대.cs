            int n = int.Parse(Console.ReadLine()); // 첫번째 입력

            int[] arr = new int[n]; // n 갯수만큼 배열 생성

            string[] s = Console.ReadLine().Split(); // 두번째 입력, 공백 기준으로 배열 저장


            // 요소만큼 int로 바꿔서 저장
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(s[i]);
            }

            Array.Sort(arr); // 배열 정렬

            Console.WriteLine($"{ arr[0]} { arr[n-1]}");