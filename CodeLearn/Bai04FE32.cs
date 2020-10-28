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
        public Diemdd dc;

        public void Nhap()
        {
            Console.WriteLine("Nhap diem dau");
            do
            {
                Console.WriteLine("Nhap ox diem dau");
                dd.ox = double.Parse(Console.ReadLine());
                if (dd.ox < -1000 || dd.ox > 1000)
                    Console.WriteLine("Nhap lai ox diem dau");
            }
            while (dd.ox < -1000 || dd.ox > 1000);
            do
            {
                Console.WriteLine("Nhap oy diem dau");
                dd.oy = double.Parse(Console.ReadLine());
                if ((dd.oy < -1000 || dd.oy > 1000) || dd.ox >= dd.oy)
                    Console.WriteLine("Nhap lai oy diem dau");
            }
            while ((dd.oy < -1000 || dd.oy > 1000) || dc.ox >= dc.oy);
            do
            {
                Console.WriteLine("Nhap ox diem cuoi");
                dc.ox = double.Parse(Console.ReadLine());
                if (dc.ox < -1000 || dc.ox > 1000)
                    Console.WriteLine("Nhap lai ox diem cuoi");
            }
            while (dc.ox < -1000 || dc.ox > 1000);
            do
            {
                Console.WriteLine("Nhap oy diem cuoi");
                dc.oy = double.Parse(Console.ReadLine());
                if ((dc.oy < -1000 || dc.oy > 1000) || dc.ox >= dc.oy)
                    Console.WriteLine("Nhap lai oy cuoi");
            }
            while ((dc.oy < -1000 || dc.oy > 1000) || dc.ox >= dc.oy);
        }
    }
}