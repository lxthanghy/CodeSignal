using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

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

        private static bool strengthCompare(int tayTraiA, int tayPhaiA, int tayTraiB, int tayPhaiB)
        {
            if ((tayTraiA == tayTraiB && tayPhaiA == tayPhaiB) || (tayTraiA == tayPhaiB && tayPhaiA == tayTraiB))
                return true;
            else
                return false;
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

        private static int[][] deleteRowsColumns(int[][] inputMatrix, int[] deleteRows, int[] deleteColumns)
        {
            //int[] deleteRows = new int[] { 4, 6, 7 };
            //int[] deleteColumns = new int[] { 1, 2, 3, 4 };
            //int[][] inputMatrix = new int[][]
            //{
            //    new int[]{ 1, 2, 5, 6, 7, 8, 9 },
            //    new int[]{ 3, 4, 5, 6, 7, 8, 9 },
            //    new int[]{ 2, 5, 6, 7, 8, 9, 4 },
            //    new int[]{ 7, 4, 5, 6, 8, 3, 1 },
            //    new int[]{ 5, 8, 9, 2, 6, 5, 7 },
            //    new int[]{ 8, 5, 6, 1, 2, 3, 6 },
            //    new int[]{ 5, 2, 6, 8, 7, 2, 6 },
            //};
            //deleteRowsColumns(inputMatrix, deleteRows, deleteColumns);
            int n = 0;
            int lengthRows = inputMatrix.Length - deleteRows.Length;
            int lengthCols = inputMatrix[0].Length - deleteColumns.Length;
            int[][] res = new int[lengthRows][];
            for (int i = 0; i < inputMatrix.Length; ++i)
            {
                if (!deleteRows.Contains(i + 1))
                {
                    int m = 0;
                    res[n] = new int[lengthCols];
                    for (int j = 0; j < inputMatrix[i].Length; ++j)
                    {
                        if (!deleteColumns.Contains(j + 1))
                        {
                            res[n][m++] = inputMatrix[i][j];
                        }
                    }
                    n++;
                }
            }
            return res;
        }

        private static int[] botBanking_(int[] accounts, string[] requests)
        {
            //int[] accounts = new int[] { 80, 200, 300, 10, 60 };
            //string[] requests = new string[]
            //{
            //    "deposit 3 400",
            //    "transfer 1 2 30",
            //    "withdraw 4 50"
            //};
            //botBanking_(accounts, requests);
            int[] res;
            int a, b, money;
            int length = accounts.Length;
            for (int i = 0; i < requests.Length; ++i)
            {
                string[] temp = requests[i].Split(' ');
                switch (temp[0])
                {
                    case "transfer":
                        a = int.Parse(temp[1]) - 1;
                        b = int.Parse(temp[2]) - 1;
                        money = int.Parse(temp[3]);
                        if (a < length && b < length)
                        {
                            accounts[a] -= money;
                            if (accounts[a] < 0)
                                return res = new int[1] { -(i + 1) };
                            accounts[b] += money;
                        }
                        else
                            return res = new int[1] { -(i + 1) };
                        break;

                    case "deposit":
                        a = int.Parse(temp[1]) - 1;
                        money = int.Parse(temp[2]);
                        if (a < length)
                            accounts[a] += money;
                        else
                            return res = new int[1] { -(i + 1) };
                        break;

                    case "withdraw":
                        a = int.Parse(temp[1]) - 1;
                        money = int.Parse(temp[2]);
                        if (a < length)
                        {
                            accounts[a] -= money;
                            if (accounts[a] < 0)
                                return res = new int[1] { -(i + 1) };
                        }
                        else
                            return res = new int[1] { -(i + 1) };
                        break;
                }
            }
            return accounts;
        }

        private static int Cau43()
        {
            int I = 2, S = 1, F = 1, R = 1;
            while (I <= 8)
            {
                I++; S = F + R; F = R; R = S;
            }
            return S;
        }

        private static void Bai01Fe(int length, string strSource, string strFind)
        {
            // ----- HÀM MAIN ---------//
            //StreamReader sr = File.OpenText(@"E:\bai1.txt");
            //int length = int.Parse(sr.ReadLine());
            //string str = sr.ReadLine();
            //Bai01Fe(length, str, "a");
            // ----- END MAIN ---------//

            //Đọc file txt
            StreamWriter sw = File.CreateText(@"E:\bai1_out.txt");
            strSource = strSource.ToLower();
            strFind = strFind.ToLower();
            //Biến lưu vị trí ký tự trong chuỗi nguồn
            string resIndex = "";
            //Biến đếm số lượng ký tự khớp
            int count = 0;
            //Duyệt từng ký tự trong chuỗi nguồn
            for (int i = 0; i < length; ++i)
            {
                //Nếu khớp thì tăng biến đếm lên 1, và cộng chuỗi vị trí tìm thấy
                if (strSource[i].ToString().Equals(strFind))
                {
                    ++count;
                    resIndex += i + "\t";
                }
            }
            sw.WriteLine(count);
            sw.WriteLine(resIndex);
            sw.Close();
            Console.WriteLine("Done!");
        }

        private static int CoinChange(int[] coins, int amount)
        {
            //int[] coins = new int[] { 1, 2, 5 };
            //int amount = 11;
            //Console.WriteLine(CoinChange(coins, amount));
            int[] dp = new int[amount + 1];
            Array.Fill(dp, amount + 1);
            dp[0] = 0;
            for (int i = 0; i <= amount; ++i)
                for (int j = 0; j < coins.Length; ++j)
                    if (coins[j] <= i)
                        dp[i] = Math.Min(dp[i], 1 + dp[i - coins[j]]);
            return dp[amount] > amount ? -1 : dp[amount];
        }

        private static int[] insertArray(int[] arr, int x)
        {
            //int[] arr = new int[] { 1, 2, 2, 2, 2 };
            //insertArray(arr, 2);
            int length = arr.Length;
            List<int> res = new List<int>();
            bool ok = false;
            for (int i = 0; i < length - 1; ++i)
            {
                res.Add(arr[i]);
                if (!ok)
                {
                    if (arr[i] <= x && x <= arr[i + 1])
                    {
                        ok = true;
                        res.Add(x);
                    }
                }
            }
            res.Add(arr[length - 1]);
            if (!ok)
                res.Add(x);
            return res.ToArray();
        }

        private static string UpperCase(string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;
            str = str.Trim();
            string res = "";
            string[] arr = str.Split(' ');
            foreach (string s in arr)
            {
                int length = s.Length;
                res += s[0].ToString().ToUpper() + s.Substring(1, length - 1);
            }
            return res;
        }

        private static void Main(string[] args)
        {
            Console.WriteLine(UpperCase("test case"));
            Console.ReadKey();
        }
    }
}