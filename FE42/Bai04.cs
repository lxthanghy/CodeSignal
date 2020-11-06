using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FE42
{
    internal class Bai04
    {
        private int[] menhgia = new int[] { 100, 50, 20, 10, 5, 1 };
        private int[] soto = new int[6];
        private int[] phuongan = new int[6];
        private int n;

        public void Nhap()
        {
            Console.WriteLine("Nhap so tien: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < menhgia.Length; ++i)
            {
                do
                {
                    Console.WriteLine("Nhap so to tien cho menh gia {0}", menhgia[i]);
                    soto[i] = int.Parse(Console.ReadLine());
                    if (soto[i] < 0 || soto[i] > 100000)
                        Console.WriteLine("So to tien khong hop le!");
                }
                while (soto[i] < 0 || soto[i] > 100000);
            }
        }

        public void PhuongAnTraTien()
        {
            for (int i = 0; i < menhgia.Length; ++i)
            {
                if (soto[i] * menhgia[i] <= n)
                    phuongan[i] = soto[i];
                else
                    phuongan[i] = n / menhgia[i];
                n -= phuongan[i] * menhgia[i];
            }
        }

        public string KetQuaDoiTien()
        {
            string res = "";
            for (int i = 0; i < phuongan.Length; ++i)
                if (phuongan[i] > 0)
                    res += "Menh gia: " + menhgia[i] + " | So to: " + phuongan[i] + "\n";
            return res;
        }
    }
}