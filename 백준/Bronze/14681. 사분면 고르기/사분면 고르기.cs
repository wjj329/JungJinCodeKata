            string a = Console.ReadLine();
            string b = Console.ReadLine();
            int x = int.Parse(a);
            int y = int.Parse(b);

            if (x > 0 && y > 0) Console.WriteLine("1");
            else if (x < 0 && y > 0) Console.WriteLine("2");
            else if (x < 0 && y < 0) Console.WriteLine("3");
            else if (x > 0 && y < 0) Console.WriteLine("4");
            else Console.WriteLine("예외처리");