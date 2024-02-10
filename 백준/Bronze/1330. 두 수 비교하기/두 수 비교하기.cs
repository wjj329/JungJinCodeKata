            string[] a = Console.ReadLine().Split();
            int b = int.Parse(a[0]);
            int c = int.Parse(a[1]);

            if (b > c) Console.WriteLine(">");
            if (b < c) Console.WriteLine("<");
            if (b == c) Console.WriteLine("==");