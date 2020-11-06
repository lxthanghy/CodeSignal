using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De01FE
{
    internal class Bai01
    {
        public string Id { get; set; }
        public string Account { get; set; }
        public string Pass { get; set; }

        public string Detail { get; set; }

        public void Nhap()
        {
            do
            {
                Console.WriteLine("Nhap Id: ");
                Id = Console.ReadLine();
                if (Id == "")
                    Console.WriteLine("Id phai khac rong !");
            }
            while (Id == "");
            do
            {
                Console.WriteLine("Nhap account: ");
                Account = Console.ReadLine();
                if (Account == "")
                    Console.WriteLine("Account phai khac rong !");
            }
            while (Account == "");
            do
            {
                Console.WriteLine("Nhap password: ");
                Pass = Console.ReadLine();
                if (Pass == "")
                    Console.WriteLine("Password phai khac rong !");
            }
            while (Pass == "");
            Console.WriteLine("Nhap detail: ");
            Detail = Console.ReadLine();
        }

        public string DanhGia()
        {
            string chuthuong = "abcdefghijklmnopqrstuvwxyz";
            string chuhoa = chuthuong.ToUpper();
            string so = "0123456789";
            int danhgia = 0;
            if (Pass.Length >= 6)
                danhgia += 1;
            int danhgia2 = 0;
            int danhgia3 = 0;
            bool coChuThuong = false;
            bool coChuHoa = false;
            bool coSo = false;
            for (int i = 0; i < Pass.Length; ++i)
            {
                if (danhgia3 == 0)
                    if (chuthuong.Contains(Pass[i]) == false && chuhoa.Contains(Pass[i]) == false && so.Contains(Pass[i]) == false)
                        danhgia3 = 1;
                if (coChuHoa == false)
                    if (chuhoa.Contains(Pass[i]))
                        coChuHoa = true;
                if (coChuThuong == false)
                    if (chuthuong.Contains(Pass[i]))
                        coChuThuong = true;
                if (coSo == false)
                    if (so.Contains(Pass[i]))
                        coSo = true;
            }
            if (coChuThuong && coChuHoa && coSo)
                danhgia2 = 1;
            danhgia = danhgia + danhgia2 + danhgia3;
            string res = "";
            switch (danhgia)
            {
                case 0: res = "Kem"; break;
                case 1: res = "Trung Binh"; break;
                case 2: res = "Tot"; break;
                default: res = "Tot"; break;
            }
            return res;
        }
    }
}