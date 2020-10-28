using System;
using System.Collections.Generic;
using System.Text;

namespace CodeLearn
{
    internal class Bai03FE32
    {
        public void mainn()
        {
            int n;
            do
            {
                Console.WriteLine("Nhap so sinh vien: ");
                n = int.Parse(Console.ReadLine());
                if (n < 0)
                    Console.WriteLine("Nhap lai !");
            }
            while (n < 0);
            List<Sv> dssv = new List<Sv>();
            for (int i = 1; i <= n; ++i)
            {
                Console.WriteLine("Nhap thong tin sinh vien thu " + i);
                Sv s = new Sv();
                s.Nhap();
                dssv.Add(s);
            }
            Console.WriteLine("Ma sinh vien\tTen sinh vien\tDiemTB\tXep loai");
            foreach (Sv v in dssv)
                v.hienThi();
        }
    }

    public struct Diem
    {
        public double diem1;
        public double diem2;
        public double diem3;
    }

    public class Sv
    {
        public string MaSinhVien { get; set; }
        public string TenSinhVien { get; set; }
        public Diem DiemSv;

        public void Nhap()
        {
            do
            {
                Console.WriteLine("Nhap ma sinh vien: ");
                MaSinhVien = Console.ReadLine();
                if (string.IsNullOrEmpty(MaSinhVien))
                    Console.WriteLine("Nhap lai ma sinh vien!");
            }
            while (string.IsNullOrEmpty(MaSinhVien));
            do
            {
                Console.WriteLine("Nhap ten sinh vien: ");
                TenSinhVien = Console.ReadLine();
                if (string.IsNullOrEmpty(TenSinhVien))
                    Console.WriteLine("Nhap lai ten sinh vien!");
            }
            while (string.IsNullOrEmpty(TenSinhVien));
            do
            {
                Console.WriteLine("Nhap diem 1: ");
                DiemSv.diem1 = int.Parse(Console.ReadLine());
                if (DiemSv.diem1 < 0 || DiemSv.diem1 > 10)
                    Console.WriteLine("Nhap lai diem 1");
            }
            while (DiemSv.diem1 < 0 || DiemSv.diem1 > 10);
            do
            {
                Console.WriteLine("Nhap diem 2: ");
                DiemSv.diem2 = int.Parse(Console.ReadLine());
                if (DiemSv.diem2 < 0 || DiemSv.diem2 > 10)
                    Console.WriteLine("Nhap lai diem 2");
            }
            while (DiemSv.diem2 < 0 || DiemSv.diem2 > 10);
            do
            {
                Console.WriteLine("Nhap diem 3: ");
                DiemSv.diem3 = int.Parse(Console.ReadLine());
                if (DiemSv.diem3 < 0 || DiemSv.diem3 > 10)
                    Console.WriteLine("Nhap lai diem 3");
            }
            while (DiemSv.diem3 < 0 || DiemSv.diem3 > 10);
        }

        public double diemTrungBinh(Diem diemsv)
        {
            return (diemsv.diem1 + diemsv.diem2 + diemsv.diem3) * 1.0 / 3;
        }

        public string thiLai(Diem diemsv)
        {
            return (diemsv.diem1 < 5 || diemsv.diem2 < 5 || diemsv.diem3 < 5) ? "Thi lai" : "Khong thi lai";
        }

        public void hienThi()
        {
            Console.WriteLine("{0}\t{1}\t{2}\t{3}", MaSinhVien, TenSinhVien, diemTrungBinh(DiemSv), thiLai(DiemSv));
        }
    }
}