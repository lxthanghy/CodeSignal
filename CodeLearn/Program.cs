using System;
using System.Collections;
using System.Linq;

namespace CodeLearn
{
    internal class Program
    {
        private static void DrawNumberTriangle1(int n)
        {
            int mid = (2 * n - 1) / 2;
            for (int i = 0; i < n; ++i)
            {
                int max = i + 1;
                for (int j = 0; j < 2 * n - 1; ++j)
                {
                    if (j >= mid - i && j <= mid + i)
                    {
                        if (i % 2 == 0)
                        {
                            if (j % 2 == 0)
                                Console.Write("{0}", max % 10);
                            else
                            {
                                if (j <= mid)
                                    max -= 1;
                                else
                                    max += 1;
                                Console.Write(" ");
                            }
                        }
                        else
                        {
                            if (j % 2 == 0)
                            {
                                if (j < mid)
                                    max -= 1;
                                else if (j > mid)
                                    max += 1;
                                Console.Write(" ");
                            }
                            else
                                Console.Write("{0}", max % 10);
                        }
                    }
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        private static void DrawNumberTriangle2(int n)
        {
            int mid = (2 * n - 1) / 2;
            for (int i = 0; i < n; ++i)
            {
                int max = i + 1;
                for (int j = 0; j < 2 * n - 1; ++j)
                {
                    if (j >= mid - i && j <= mid + i)
                    {
                        if (j < mid)
                            Console.Write("{0}", (max--) % 10);
                        else if (j >= mid)
                            Console.Write("{0}", (max++) % 10);
                    }
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        private static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            DrawNumberTriangle2(n);
            Console.ReadKey();
        }
    }
}