using System;
using System.Collections.Generic;
using System.Text;

namespace CodeLearn
{
    internal class Bai04FE32
    {
        public void main()
        {
            List<Doanthang> dsdt = new List<Doanthang>();
            for (int i = 1; i <= 5; ++i)
            {
                Console.WriteLine("Nhap thong tin doan thang thu {0}", i);
                Doanthang dt = new Doanthang();
                dt.Nhap();
                dsdt.Add(dt);
            }
            foreach (Doanthang dt in dsdt)
                dt.HienThi();
            Console.WriteLine();
            for (int i = 0; i < dsdt.Count - 1; ++i)
            {
                int min_index = i;
                for (int j = i + 1; j < dsdt.Count; ++j)
                {
                    double m = dsdt[min_index].dd.oy - dsdt[min_index].dd.ox;
                    double n = dsdt[j].dd.oy - dsdt[j].dd.ox;
                    if (m > n || (m == n && dsdt[j].dd.oy > dsdt[min_index].dd.oy))
                        min_index = j;
                }
                if (min_index != i)
                {
                    Doanthang tmp = dsdt[min_index];
                    dsdt[min_index] = dsdt[i];
                    dsdt[i] = tmp;
                }
            }
            foreach (Doanthang dt in dsdt)
                dt.HienThi();
        }
    }

    public struct Diemdd
    {
        public double ox;
        public double oy;
    }

    public class Doanthang
    {
        public Diemdd dd;

        public void Nhap()
        {
            do
            {
                Console.WriteLine("Nhap diem dau");
                dd.ox = double.Parse(Console.ReadLine());
                if (dd.ox < -1000 || dd.ox > 1000)
                    Console.WriteLine("Nhap lai ox diem dau");
            }
            while (dd.ox < -1000 || dd.ox > 1000);
            do
            {
                Console.WriteLine("Nhap diem cuoi");
                dd.oy = double.Parse(Console.ReadLine());
                if ((dd.oy < -1000 || dd.oy > 1000) || dd.ox >= dd.oy)
                    Console.WriteLine("Nhap lai oy diem dau");
            }
            while ((dd.oy < -1000 || dd.oy > 1000) || dd.ox >= dd.oy);
        }

        public void HienThi()
        {
            Console.WriteLine("{0},{1}", dd.ox, dd.oy);
        }
    }
}