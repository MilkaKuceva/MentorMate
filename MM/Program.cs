using System;

namespace MM
{
    class Program
    {
        const char c1 = '-';
        const char c2 = '*';

        static void Main(string[] args)
        {
            int N;

            while (true)
            {
                Console.Write("N = ");
                if (!int.TryParse(Console.ReadLine(), out N))
                {
                    Console.WriteLine("Invalid value! Try again!");
                    continue;
                }

                if (N <= 2 || N >= 10000 || N % 2 == 0)
                {
                    Console.WriteLine("Incorrect N! Try again!");
                    continue;
                }
                break;
            }

            int n = N;
            int a = n; // ****
            int b = n; // ----
            int limit = N / 2 + 1;

            // 1st 1/2 rows
            for (; n >= limit; n--)
            {
                // 1st M
                PrintSymbol(c1, n);
                PrintSymbol(c2, a);
                PrintSymbol(c1, b);
                PrintSymbol(c2, a);
                PrintSymbol(c1, n);

                // 2nd M
                PrintSymbol(c1, n);
                PrintSymbol(c2, a);
                PrintSymbol(c1, b);
                PrintSymbol(c2, a);
                PrintSymbol(c1, n);
                Console.WriteLine();
                a += 2;
                b -= 2;
            }

            b = a - 2;
            a = 1;
            // 2nd 1/2 rows
            for (; n >= 0; n--)
            {
                // 1st M
                PrintSymbol(c1, n);
                PrintSymbol(c2, N);
                PrintSymbol(c1, a);
                PrintSymbol(c2, b);
                PrintSymbol(c1, a);
                PrintSymbol(c2, N);
                PrintSymbol(c1, n);

                // 2nd M
                PrintSymbol(c1, n);
                PrintSymbol(c2, N);
                PrintSymbol(c1, a);
                PrintSymbol(c2, b);
                PrintSymbol(c1, a);
                PrintSymbol(c2, N);
                PrintSymbol(c1, n);
                Console.WriteLine();

                a += 2;
                b -= 2;
            }
        }

        private static void PrintSymbol(char c, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(c);
            }
        }
    }
}
