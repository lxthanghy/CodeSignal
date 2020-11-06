using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De01FE
{
    internal struct CongNhan
    {
        public string MaCongNhan;
        public string TenCongNhan;
        public int SoNgayLamViec;
    }

    internal class Node
    {
        public Node pNext;
        public CongNhan info;
    }

    internal class DanhSachCongNhan
    {
        public Node Head, Tail;

        public DanhSachCongNhan()
        {
            Head = Tail = null;
        }

        public Node createNode(CongNhan cn)
        {
            Node node = new Node();
            node.info = cn;
            node.pNext = null;
            return node;
        }

        public void ThemCongNhan(CongNhan cn)
        {
            Node cnt = createNode(cn);
            if (Head == null)
                Head = Tail = cnt;
            else
            {
                Tail.pNext = cnt;
                Tail = cnt;
            }
        }

        public void TimKiemCongNhan(string ten)
        {
            Node cn = Head;
            List<Node> dsCongNhan = new List<Node>();
            while (cn != null)
            {
                if (cn.info.TenCongNhan.Contains(ten))
                    dsCongNhan.Add(cn);
                cn = cn.pNext;
            }
            foreach (Node n in dsCongNhan)
            {
                Console.WriteLine(n.info.TenCongNhan);
            }
        }

        public void hienThi()
        {
            Node cn = Head;
            while (cn != null)
            {
                Console.WriteLine(cn.info.TenCongNhan);
                cn = cn.pNext;
            }
        }
    }

    internal class Bai02
    {
        public static CongNhan NhapCongNhan()
        {
            CongNhan cn = new CongNhan();
            Console.WriteLine("Nhap ma cong nhan: ");
            cn.MaCongNhan = Console.ReadLine();
            Console.WriteLine("Nhap ten cong nhan: ");
            cn.TenCongNhan = Console.ReadLine();
            Console.WriteLine("Nhap so ngay lam viec : ");
            cn.SoNgayLamViec = int.Parse(Console.ReadLine());
            return cn;
        }

        public void Run()
        {
            DanhSachCongNhan dscn = new DanhSachCongNhan();
            do
            {
                Console.WriteLine("1: Nhap thong tin cong nhan - 2: thoat");
                int key = int.Parse(Console.ReadLine());
                if (key == 1)
                {
                    CongNhan cn = NhapCongNhan();
                    dscn.ThemCongNhan(cn);
                }
                else if (key == 2)
                    break;
            }
            while (true);
            dscn.hienThi();
            Console.WriteLine("Nhap ten can tim: ");
            string ten = Console.ReadLine();
            dscn.TimKiemCongNhan(ten);
        }
    }
}