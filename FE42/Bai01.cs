using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FE42
{
    internal class Bai01
    {
        public string MaKhachHang { get; set; }
        public string HoTen { get; set; }
        public double TienGoc { get; set; }
        public int KyHan { get; set; }

        public void Nhap()
        {
            do
            {
                Console.WriteLine("Nhap ma khach hang: ");
                MaKhachHang = Console.ReadLine().Trim();
                if (MaKhachHang == "")
                    Console.WriteLine("Ma khach hang khong duoc de trong!");
            }
            while (MaKhachHang == "");
            do
            {
                Console.WriteLine("Nhap ten khach hang: ");
                HoTen = Console.ReadLine().Trim();
                if (HoTen == "")
                    Console.WriteLine("Ma khach hang khong duoc de trong!");
            }
            while (HoTen == "");
            do
            {
                Console.WriteLine("Nhap so tien gui: ");
                TienGoc = double.Parse(Console.ReadLine());
                if (TienGoc <= 0)
                    Console.WriteLine("So tien gui phai la so duong!");
            }
            while (TienGoc <= 0);
            do
            {
                Console.WriteLine("Nhap ky han: ");
                KyHan = int.Parse(Console.ReadLine());
                if (KyHan < 0)
                    Console.WriteLine("Ky han phai la so khong am!");
            }
            while (KyHan < 0);
        }

        public double TinhTien(double tienGoc, int kyHan)
        {
            double LaiXuat = 0.6 / 100;
            if (kyHan > 12) LaiXuat = 9 * 1.0 / 100;
            else if (kyHan >= 6 && kyHan <= 12) LaiXuat = 7.1 / 100;
            else if (kyHan >= 1 && kyHan < 6) LaiXuat = 5.5 / 100;
            double Tien = tienGoc + tienGoc * LaiXuat / 12 * kyHan;
            return Tien;
        }
    }
}