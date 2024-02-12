            string[] s = Console.ReadLine().Split();
            int a = int.Parse(s[0]), b = int.Parse(s[1]), c = int.Parse(s[2]);

            if (a == b && a == c)
            {
                Console.WriteLine(10000 + a * 1000);
            }
            else if (a == b && a != c || a != b && a == c)
            {
                Console.WriteLine(1000 + a * 100);
            }
            else if (b == c && b != a)
            {
                Console.WriteLine(1000 + b * 100);
            }
            else
            {
                int biggest = a;
                if (biggest < b) biggest = b; 
                if (biggest < c) biggest = c;
                Console.WriteLine(biggest * 100);
            }