            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i< n; i++)
            {
                for (int j = n-1; j >= i + 1; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i+1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }