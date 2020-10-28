using System;
using System.Collections.Generic;
using System.Text;

namespace CodeLearn
{
    public class Congnhan
    {
        public string Ma { get; set; }
        public string Hoten { get; set; }
        public int Sn { get; set; }

        public void Nhap()
        {
            do
            {
                Console.WriteLine("Nhap ma:");
                Ma = Console.ReadLine();
                if (string.IsNullOrEmpty(Ma))
                    Console.WriteLine("Nhap lai ma!");
            }
            while (string.IsNullOrEmpty(Ma));
            do
            {
                Console.WriteLine("Nhap ho ten:");
                Hoten = Console.ReadLine();
                if (string.IsNullOrEmpty(Ma))
                    Console.WriteLine("Nhap lai ho ten!");
            }
            while (string.IsNullOrEmpty(Hoten));
            do
            {
                Console.WriteLine("Nhap so ngay lam viec trong thang:");
                Sn = int.Parse(Console.ReadLine());
                if (Sn < 0 || Sn > 31)
                    Console.WriteLine("Nhap lai so ngay lam viec!");
            }
            while (Sn < 0 || Sn > 31);
        }

        public string hienThiLuongVaDanhGia(int sn)
        {
            if (sn >= 25)
                return "ghi chu: Cham chi, luong: " + (200000 * sn);
            if (sn < 15)
                return "ghi chu: Nghi nhieu, luong: " + (150000 * sn);
            return "ghi chu: , luong: " + (180000 * sn);
        }
    }
}