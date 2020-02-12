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
                if (int.TryParse(Console.ReadLine(), out N) == false)
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
            int a; //----
            int b = n; //****
            int c = n; //----
            int limit = N / 2 + 1;
            int i;
            for (; n >= limit; n--)
            {
                //a = n;
                PrintSymbol(c1, n);
                PrintSymbol(c2, b);
                PrintSymbol(c1, c);
                PrintSymbol(c2, b);
                PrintSymbol(c1, n);

                //second part
                PrintSymbol(c1, n);
                PrintSymbol(c2, b);
                PrintSymbol(c1, c);
                PrintSymbol(c2, b);
                PrintSymbol(c1, n);
                Console.WriteLine();
                b += 2;
                c -= 2;
            }
            c = b - 2;
            b = 1;

            for (; n >= 0; n--)
            {
                PrintSymbol(c1, n);
                PrintSymbol(c2, N);
                PrintSymbol(c1, b);
                PrintSymbol(c2, c);
                PrintSymbol(c1, b);
                PrintSymbol(c2, N);
                PrintSymbol(c1, n);

                //second part
                PrintSymbol(c1, n);
                PrintSymbol(c2, N);
                PrintSymbol(c1, b);
                PrintSymbol(c2, c);
                PrintSymbol(c1, b);
                PrintSymbol(c2, N);
                PrintSymbol(c1, n);
                Console.WriteLine();

                b += 2;
                c -= 2;
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
