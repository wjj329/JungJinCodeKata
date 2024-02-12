            string[] a = Console.ReadLine().Split();
            int h = int.Parse(a[0]), m = int.Parse(a[1]), c = int.Parse(Console.ReadLine());

            m += c;

            while (m >= 60) // 분이 60 이상인 경우 처리
            {
                m -= 60;
                h += 1;
            }

            while (m < 0) // 분이 음수인 경우 처리
            {
                m += 60;
                h -= 1;
            }

            if (h >= 24) // 시간이 24 이상인 경우 처리
            {
                h -= 24;
            }
            else if (h < 0) // 시간이 음수인 경우 처리
            {
                h += 24;
            }
            Console.WriteLine($"{h} {m}");