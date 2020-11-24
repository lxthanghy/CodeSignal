using System;
using System.Collections.Generic;
using System.Text;

namespace CodeLearn
{
    //Copy code vào main để chạy
    //CodeBill codeBill = new CodeBill();
    //codeBill.Input();
    //codeBill.Output();
    public class CodeBill
    {
        public string ngayBatDau = "";
        public string maDonVi = "";
        public int soHoaDonTrong1Ngay, soNgayInHoaDon;

        public void Input()
        {
            int ngayBatDauHoaDon, thangBatDauHoaDon, namBatDauHoaDon, soNgayTrongThang;
            do
            {
                Console.Write("Ngay bat dau (ngay/thang/nam): ");
                ngayBatDau = Console.ReadLine().Trim();
                string[] catNgayBatDau = ngayBatDau.Split('/');
                ngayBatDauHoaDon = int.Parse(catNgayBatDau[0]);
                thangBatDauHoaDon = int.Parse(catNgayBatDau[1]);
                namBatDauHoaDon = int.Parse(catNgayBatDau[2]);
                soNgayTrongThang = DateTime.DaysInMonth(namBatDauHoaDon, thangBatDauHoaDon);
                if ((thangBatDauHoaDon < 1 || thangBatDauHoaDon > 12) || (namBatDauHoaDon < 1 || namBatDauHoaDon > 9999) || (ngayBatDauHoaDon < 1 || ngayBatDauHoaDon > soNgayTrongThang))
                    Console.WriteLine("Nhap lai ngay bat dau !");
            }
            while ((thangBatDauHoaDon < 1 || thangBatDauHoaDon > 12) || (namBatDauHoaDon < 1 || namBatDauHoaDon > 9999) || (ngayBatDauHoaDon < 1 || ngayBatDauHoaDon > soNgayTrongThang));
            Console.WriteLine();
            do
            {
                Console.Write("DepartmentName: ");
                maDonVi = Console.ReadLine().Trim().ToUpper();
                if (maDonVi.Length != 3)
                    Console.WriteLine("Nhap lai ma don vi !");
            }
            while (maDonVi.Length != 3);
            Console.WriteLine();
            do
            {
                try
                {
                    Console.Write("So hoa don trong 1 ngay: ");
                    soHoaDonTrong1Ngay = int.Parse(Console.ReadLine());
                    if (soHoaDonTrong1Ngay <= 0)
                        Console.WriteLine("So hoa don trong 1 ngay phai > 0 !");
                }
                catch (Exception)
                {
                    soHoaDonTrong1Ngay = -1;
                    Console.WriteLine("So hoa don trong 1 ngay phai la so !");
                }
            }
            while (soHoaDonTrong1Ngay <= 0);
            Console.WriteLine();
            do
            {
                try
                {
                    Console.Write("So ngay in hoa don: ");
                    soNgayInHoaDon = int.Parse(Console.ReadLine());
                    if (soNgayInHoaDon <= 0)
                        Console.WriteLine("So ngay in hoa don phai > 0 !");
                }
                catch (Exception)
                {
                    soNgayInHoaDon = -1;
                    Console.WriteLine("So ngay in hoa don phai la so !");
                }
            }
            while (soNgayInHoaDon <= 0);
            Console.WriteLine();
        }

        public void Output()
        {
            string[] catNgayBatDau = ngayBatDau.Split('/');
            int ngayBatDauHoaDon = int.Parse(catNgayBatDau[0]);
            int thangBatDauHoaDon = int.Parse(catNgayBatDau[1]);
            int namBatDauHoaDon = int.Parse(catNgayBatDau[2]);
            int soNgayTrongThang = DateTime.DaysInMonth(namBatDauHoaDon, thangBatDauHoaDon);
            if (soNgayInHoaDon < soNgayTrongThang - ngayBatDauHoaDon)
            {
                // Trong tháng
                int count = 1;
                for (int i = ngayBatDauHoaDon; i <= ngayBatDauHoaDon + soNgayInHoaDon; ++i)
                {
                    string s = "";
                    for (int j = 1; j <= soHoaDonTrong1Ngay; ++j)
                    {
                        string t = count.ToString();
                        for (int k = t.Length; k <= 5; ++k)
                            t = "0" + t;
                        int nam = thangBatDauHoaDon < 4 ? namBatDauHoaDon - 1 : namBatDauHoaDon;
                        s += $"{maDonVi}FY{nam}{t} ";
                        ++count;
                    }
                    string ngay = i > 10 ? $"{i}" : $"0{i}";
                    string thang = thangBatDauHoaDon > 10 ? $"{thangBatDauHoaDon}" : $"0{thangBatDauHoaDon}";
                    Console.WriteLine($"{ngay}/{thang}/{namBatDauHoaDon}: {s}");
                }
            }
            else
            {
                //Sang tháng sau
                int count = 1;
                for (int i = ngayBatDauHoaDon; i <= soNgayTrongThang; ++i)
                {
                    string s = "";
                    for (int j = 1; j <= soHoaDonTrong1Ngay; ++j)
                    {
                        string t = count.ToString();
                        for (int k = t.Length; k <= 5; ++k)
                            t = "0" + t;
                        int nam = thangBatDauHoaDon < 4 ? namBatDauHoaDon - 1 : namBatDauHoaDon;
                        s += $"{maDonVi}FY{nam}{t} ";
                        ++count;
                    }
                    string ngay = i > 10 ? $"{i}" : $"0{i}";
                    string thang = thangBatDauHoaDon > 10 ? $"{thangBatDauHoaDon}" : $"0{thangBatDauHoaDon}";
                    Console.WriteLine($"{ngay}/{thang}/{namBatDauHoaDon}: {s}");
                }
                ++thangBatDauHoaDon;
                count = 1;
                for (int i = 1; i <= soNgayInHoaDon - (soNgayTrongThang - ngayBatDauHoaDon + 1); ++i)
                {
                    string s = "";
                    for (int j = 1; j <= soHoaDonTrong1Ngay; ++j)
                    {
                        string t = count.ToString();
                        for (int k = t.Length; k <= 5; ++k)
                            t = "0" + t;
                        int nam = thangBatDauHoaDon < 4 ? namBatDauHoaDon - 1 : namBatDauHoaDon;
                        s += $"{maDonVi}FY{nam}{t} ";
                        ++count;
                    }
                    string ngay = i > 10 ? $"{i}" : $"0{i}";
                    string thang = thangBatDauHoaDon > 10 ? $"{thangBatDauHoaDon}" : $"0{thangBatDauHoaDon}";
                    Console.WriteLine($"{ngay}/{thang}/{namBatDauHoaDon}: {s}");
                }
            }
        }
    }
}