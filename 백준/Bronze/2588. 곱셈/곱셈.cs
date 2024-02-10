string a = Console.ReadLine(); // (1) : 그림 1번
            string b = Console.ReadLine(); // (2)

            Console.WriteLine(int.Parse(a) * (int)Char.GetNumericValue(b[2])); // (3) b의 세 번째 요소 = 1의 자리
            Console.WriteLine(int.Parse(a) * (int)Char.GetNumericValue(b[1])); // (4) b의 두 번째 요소 = 10의 자리
            Console.WriteLine(int.Parse(a) * (int)Char.GetNumericValue(b[0])); // (5) b의 첫 번째 요소 = 100의 자리
            Console.WriteLine(int.Parse(a) * int.Parse(b)); // (6) 결과 값 계산