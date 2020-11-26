using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DeFE4._2;

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
            //Console.WriteLine(UpperCase("test case"));
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

        private static string convertDectoBin(int dec)
        {
            string res = "";
            while (dec != 0)
            {
                res = (dec % 2) + "" + res;
                dec /= 2;
            }
            return res;
        }

        private static bool KiemTraDoiXung(string str)
        {
            int i = 0;
            int j = str.Length - 1;
            while (i < j)
            {
                if (str[i] != str[j])
                    return false;
                ++i;
                --j;
            }
            return true;
        }

        private static string TimSoLonThuHai(int[] num)
        {
            int s1_number = num[0];
            int s2_number = s1_number;
            for (int i = 1; i < num.Length; ++i)
                if (num[i] > s1_number)
                    s1_number = num[i];
            for (int i = 1; i < num.Length; ++i)
                if (num[i] > s2_number && num[i] != s1_number)
                    s2_number = num[i];
            if (s1_number == s2_number) return "Mảng không có sô lớn thứ 2 !";
            return $"Số lớn nhất: {s1_number} | số lớn thứ hai: {s2_number}";
        }

        private static int TimGiaTriGanTrungBinh(int[] num)
        {
            int length = num.Length;
            int sum = 0;
            for (int i = 0; i < length; ++i)
                sum += num[i];
            double avg = sum * 1.0 / length;
            int res = num[0];
            double distance_min = Math.Abs(avg - res);
            for (int i = 1; i < length; ++i)
            {
                double tmp_distance_min = Math.Abs(avg - num[i]);
                if (tmp_distance_min < distance_min)
                {
                    distance_min = tmp_distance_min;
                    res = num[i];
                }
            }
            return res;
        }

        private static int SumNumbersLargerAverage(int[] a)
        {
            long sum = 0;
            int ans = 0;
            foreach (int x in a)
                sum += x;
            double avg = sum * 1.0 / a.Length;
            foreach (int x in a)
                if (x > avg)
                    ans += x;
            return ans != 0 ? ans : -1;
        }

        private static int Fibonacci(int n)
        {
            int F0 = 0;
            int F1 = 1;
            int F = F1;
            for (int i = 2; i <= n; ++i)
            {
                F = F0 + F1;
                F0 = F1;
                F1 = F;
            }
            return F;
        }

        private static int MinConvert(int n, int m)
        {
            int min_way = 0;
            if (n == 0 && m > 0) return -1;
            if (n > m) return n - m;
            while (n != m)
            {
                if (m > n)
                {
                    if (m % 2 == 0) m /= 2;
                    else m += 1;
                    ++min_way;
                }
                else return n - m + min_way;
            }
            return min_way;
        }

        private static int TimDiemTrungBinhFPT(int[] arr)
        {
            // 1 9 6 2 3 5
            double avg = 0;
            int length = arr.Length;
            for (int i = 0; i < length; ++i)
                avg += arr[i];
            avg /= 2;
            int sum_left = 0;
            int mid = -1;
            for (int i = 0; i < length; ++i)
            {
                sum_left += arr[i];
                if (sum_left >= avg)
                {
                    mid = i;
                    if (sum_left == avg)
                    {
                        mid += 1;
                        sum_left += arr[mid];
                    }
                    break;
                }
            }
            int sum_right = 0;
            for (int j = length - 1; j >= mid; --j)
                sum_right += arr[j];
            return sum_left == sum_right ? mid : -1;
        }

        private static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 2, 2, 2 };
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(TimDiemTrungBinhFPT(arr));
            Console.ReadKey();
        }
    }
}