            int t = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < t; i++)
            {
                string[] s = Console.ReadLine().Split();
                int a = int.Parse(s[0]);
                int b = int.Parse(s[1]);

                Console.WriteLine($"Case #{i+1}: {a} + {b} = {a+b}");
            }