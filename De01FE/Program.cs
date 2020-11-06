using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De01FE
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            //Bai01 bai01 = new Bai01();
            //bai01.Nhap();
            //Console.WriteLine(bai01.DanhGia());
            //Bai02 bai02 = new Bai02();
            //bai02.Run();
            Bai03 bai03 = new Bai03();
            bai03.Nhap();
            bai03.HienThi();
            Console.ReadKey();
        }
    }
}