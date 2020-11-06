using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeFE4._2
{
    internal class Bai04
    {
        public string Solve()
        {
            string res = "";
            int n = 4;
            int[] menhgia = new int[] { 100, 50, 20, 10, 5, 1 };
            int[] soto = new int[] { 1, 2, 10, 10, 100, 3 };
            int[] ketqua = new int[6];
            for (int i = 0; i < menhgia.Length; ++i)
            {
                if (menhgia[i] * soto[i] <= n)
                    ketqua[i] = soto[i];
                else
                    ketqua[i] = n / menhgia[i];
                n -= menhgia[i] * ketqua[i];
            }
            for (int i = 0; i < ketqua.Length; ++i)
                if (ketqua[i] > 0)
                    res += "Menh gia: " + menhgia[i] + " | So to: " + ketqua[i] + "\n";
            if (n > 0)
            {
                Console.WriteLine("May khong du tien de doi, tien thua la: {0}", n);
            }
            return res;
        }
    }
}