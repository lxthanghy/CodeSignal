using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FE42
{
    internal struct Diem
    {
        public double mon1;
        public double mon2;
        public double mon3;
    }

    internal class HocSinh
    {
        public string MaHocSinh { get; set; }
        public string TenHocSinh { get; set; }
        public Diem Diem;

        public void Nhap()
        {
            do
            {
                Console.WriteLine("Nhap ma hoc sinh: ");
                MaHocSinh = Console.ReadLine().Trim();
                if (MaHocSinh == "")
                    Console.WriteLine("Ma hoc sinh phai khac rong!");
            }
            while (MaHocSinh == "");
            do
            {
                Console.WriteLine("Nhap ten hoc sinh: ");
                TenHocSinh = Console.ReadLine().Trim();
                if (TenHocSinh == "")
                    Console.WriteLine("Ma hoc sinh phai khac rong!");
            }
            while (TenHocSinh == "");
            do
            {
                Console.WriteLine("Nhap diem mon thu 1: ");
                Diem.mon1 = double.Parse(Console.ReadLine());
                if (Diem.mon1 < 0 || Diem.mon1 > 10)
                    Console.WriteLine("Diem khong hop le!");
            }
            while (Diem.mon1 < 0 || Diem.mon1 > 10);
            do
            {
                Console.WriteLine("Nhap diem mon thu 2: ");
                Diem.mon2 = double.Parse(Console.ReadLine());
                if (Diem.mon2 < 0 || Diem.mon2 > 10)
                    Console.WriteLine("Diem khong hop le!");
            }
            while (Diem.mon2 < 0 || Diem.mon2 > 10);
            do
            {
                Console.WriteLine("Nhap diem mon thu 3: ");
                Diem.mon3 = double.Parse(Console.ReadLine());
                if (Diem.mon3 < 0 || Diem.mon3 > 10)
                    Console.WriteLine("Diem khong hop le!");
            }
            while (Diem.mon3 < 0 || Diem.mon3 > 10);
        }

        public double TrungBinhCongDiem()
        {
            return (Diem.mon1 + Diem.mon2 + Diem.mon3) / 3;
        }

        public string KiemTraHocSinh()
        {
            if (Diem.mon1 < 5 || Diem.mon2 < 5 || Diem.mon3 < 5)
                return "KQ KEM";
            else
                return "KQ TOT";
            //string res = (Diem.mon1 < 5 || Diem.mon2 < 5 || Diem.mon3 < 5) ? "KQ KEM" : "KQ TOT";
            //return res;
        }

        public void HienThi()
        {
            Console.WriteLine("{0}\t{1}\t{2}\t{3}", MaHocSinh, TenHocSinh, TrungBinhCongDiem(), KiemTraHocSinh());
        }
    }

    internal class Bai03
    {
        private List<HocSinh> hocSinhs = new List<HocSinh>();

        public void Nhap()
        {
            int n;
            do
            {
                Console.WriteLine("Nhap so hoc sinh: ");
                n = int.Parse(Console.ReadLine());
                if (n <= 0)
                    Console.WriteLine("Nhap lai so hoc sinh !");
            }
            while (n <= 0);
            for (int i = 0; i < n; ++i)
            {
                Console.WriteLine("Nhap thong tin hoc sinh thu {0}", i + 1);
                HocSinh hs = new HocSinh();
                hs.Nhap();
                hocSinhs.Add(hs);
            }
        }

        public void Hien()
        {
            Console.WriteLine("Ma hoc sinh\tTen hoc sinh\tDiemTB\tXep loai");
            foreach (HocSinh hs in hocSinhs)
                hs.HienThi();
        }
    }
}