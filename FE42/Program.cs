using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FE42
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Bai01 bai01 = new Bai01();
            //bai01.Nhap();
            //Console.WriteLine(bai01.TinhTien(bai01.TienGoc, bai01.KyHan));
            //Bai03 bai03 = new Bai03();
            //bai03.Nhap();
            //bai03.Hien();
            Bai04 bai04 = new Bai04();
            bai04.Nhap();
            bai04.PhuongAnTraTien();
            Console.WriteLine(bai04.KetQuaDoiTien());
            Console.ReadKey();
        }
    }
}