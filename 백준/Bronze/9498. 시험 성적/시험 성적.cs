            string a = Console.ReadLine();
            int b = int.Parse(a);

            if (b >= 90 && b <= 100) Console.WriteLine("A");
            else if (b >= 80 && b < 90) Console.WriteLine("B");
            else if (b >= 70 && b < 80) Console.WriteLine("C");
            else if (b >= 60 && b < 70) Console.WriteLine("D");
            else Console.WriteLine("F");