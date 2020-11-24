using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De01FE
{
    internal abstract class Phuongtien
    {
        public string Bienso { get; set; }
        public string Mauson { get; set; }

        public Phuongtien()
        {
        }

        public virtual void Nhap()
        {
            Console.WriteLine("Nhap bien so: ");
            Bienso = Console.ReadLine();
            Console.WriteLine("Nhap mau son: ");
            Mauson = Console.ReadLine();
        }

        public abstract string HienThi();
    }

    internal class Xekhach : Phuongtien
    {
        public int SoChoNgoi { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap so cho ngoi: ");
            SoChoNgoi = int.Parse(Console.ReadLine());
        }

        public override string HienThi()
        {
            return $"{Bienso}\t{Mauson}\t{SoChoNgoi}";
        }
    }

    internal class XeTai : Phuongtien
    {
        public int trongTai { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap tai trong: ");
            trongTai = int.Parse(Console.ReadLine());
        }

        public override string HienThi()
        {
            return $"{Bienso}\t{Mauson}\t{trongTai}";
        }
    }

    internal class Bai03
    {
        private List<Phuongtien> dspt = new List<Phuongtien>();

        public void Nhap()
        {
            Console.WriteLine("Nhap so phuong tien: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; ++i)
            {
                Console.WriteLine("1-Xe khach   2-Xe tai");
                int x = int.Parse(Console.ReadLine());
                if (x == 1)
                {
                    Phuongtien xekhach = new Xekhach();
                    xekhach.Nhap();
                    dspt.Add(xekhach);
                }
                else if (x == 2)
                {
                    Phuongtien xetai = new XeTai();
                    xetai.Nhap();
                    dspt.Add(xetai);
                }
            }
        }

        public void HienThi()
        {
            Console.WriteLine("STT\tBien so xe\tMau son\tSo cho ngoi/Tai trong\tLoai xe");
            for (int i = 0; i < dspt.Count; ++i)
            {
                if (dspt[i].GetType() == typeof(Xekhach))
                    Console.WriteLine("{0}\t{1}\t{2}", i + 1, dspt[i].HienThi(), "Xe Khach");
                else
                    Console.WriteLine("{0}\t{1}\t{2}", i + 1, dspt[i].HienThi(), "Xe Tai");
            }
        }
    }
}