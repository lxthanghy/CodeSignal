using System;
using System.Collections.Generic;
using System.Text;

namespace CodeLearn
{
    internal class Bai04FE32
    {
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