using System;
using System.Collections;
using System.Collections.Generic;
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

        private static int usc(int a, int b)
        {
            if (a % b == 0) return b;
            else return usc(b, a % b);
        }

        private static bool strongPassword(string pwd)
        {
            // Chữ cái viết thường: a-z (97 - 122)
            // Chữ cái viết HOA: A-Z (65 - 90)
            // Chữ số: 0-9 (48 - 57)
            // Các ký tự đặc biệt: !@#$%ˆ&*()[]{},./<>?
            if (pwd.Length >= 8 && pwd.Length <= 30)
            {
                string db = "!@#$%ˆ&*()[]{},./<>?";
                int lowercase = 0;
                int uppercase = 0;
                int number = 0;
                int specialcharacter = 0;

                for (int i = 0; i < pwd.Length; ++i)
                {
                    int c = pwd[i];
                    if ((c >= 97 && c <= 122) || (c >= 65 && c <= 90) || (c >= 48 && c <= 57) || (db.Contains(pwd[i])))
                    {
                        if (c >= 97 && c <= 122)
                            if (lowercase == 0)
                                lowercase += 1;
                        if (c >= 65 && c <= 90)
                            if (uppercase == 0)
                                uppercase += 1;
                        if (c >= 48 && c <= 57)
                            if (number == 0)
                                number += 1;
                        if (db.Contains(pwd[i]))
                            if (specialcharacter == 0)
                                specialcharacter += 1;
                        if (lowercase + uppercase + number + specialcharacter >= 3)
                            return true;
                    }
                    else return false;
                }
                return lowercase + uppercase + specialcharacter >= 3;
            }
            else
                return false;
        }

        private static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}