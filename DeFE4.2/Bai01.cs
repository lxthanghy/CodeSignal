using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeFE4._2
{
    public class Bai01
    {
        public string MaKhachHang, TenKhachHang;
        public int TienGoc, KyHan;

        public void Nhap()
        {
            do
            {
                Console.WriteLine("Nhap ma khach hang: ");
                MaKhachHang = Console.ReadLine();
                if (string.IsNullOrEmpty(MaKhachHang.Trim()))
                    Console.WriteLine("Ma khach hang khong duoc de trong !");
            }
            while (string.IsNullOrEmpty(MaKhachHang.Trim()));
            do
            {
                Console.WriteLine("Nhap ten khach hang: ");
                TenKhachHang = Console.ReadLine();
                if (string.IsNullOrEmpty(TenKhachHang.Trim()))
                    Console.WriteLine("Ten khach hang khong duoc de trong !");
            }
            while (string.IsNullOrEmpty(TenKhachHang.Trim()));
            do
            {
                try
                {
                    Console.WriteLine("Nhap so tien gui: ");
                    TienGoc = int.Parse(Console.ReadLine());
                    if (TienGoc <= 0)
                        Console.WriteLine("So tien gui phai la so duong !");
                }
                catch (Exception)
                {
                    TienGoc = 0;
                    Console.WriteLine("So tien gui phai la so !");
                }
            }
            while (TienGoc <= 0);
            do
            {
                try
                {
                    Console.WriteLine("Nhap ky han: ");
                    string input = Console.ReadLine();
                    input = input.Trim();
                    if (string.IsNullOrEmpty(input))
                        KyHan = 0;
                    else
                        KyHan = int.Parse(input);
                    if (KyHan < 0)
                        Console.WriteLine("Ky han phai la so khong am !");
                }
                catch (Exception)
                {
                    KyHan = -1;
                    Console.WriteLine("Ky han phai la so !");
                }
            }
            while (KyHan < 0);
        }

        public double TinhTien(int tienGoc, int kyHan)
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