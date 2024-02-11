            string[] a = Console.ReadLine().Split();
            int h = int.Parse(a[0]), m = int.Parse(a[1]);

            m -= 45;

            if (m < 0)
            {
                m += 60;
                h -= 1;
            }

            if (h < 0)
            {
                h += 24;
            }
            Console.WriteLine($"{h} {m}");