            int[] arr = new int[9]; // 길이9 배열

            int maxNum = 0; // 최대값 저장용 변수
            int maxIndex = 0; // 최대값 번호 저장용 변수

            for (int i = 0; i<9; i++)
            {
                arr[i] = int.Parse(Console.ReadLine()); // 9개 숫자 배열에 입력
            }

            for (int i = 0; i< 9; i++)
            {
                if (arr[i] > maxNum) // 현재 값이 최대보다 크면 maxNum
                {
                    maxNum = arr[i]; // maxNum에 저장
                    maxIndex = i + 1; // maxIndex 순서에 저장
                }
            }
            Console.WriteLine(maxNum);
            Console.WriteLine(maxIndex);