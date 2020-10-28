using System;
using System.Collections.Generic;
using System.Text;

namespace CodeLearn
{
    internal class SinhvienNode
    {
        public static Sinhvien NhapSinhVien()
        {
            Sinhvien sv = new Sinhvien();
            Console.WriteLine("Nhap ten sinh vien:");
            sv.TenSinhvien = Console.ReadLine();
            Console.WriteLine("Nhap ma lop:");
            sv.Lop = Console.ReadLine();
            return sv;
        }

        public void mainn()
        {
            ListSV lsv = new ListSV();
            do
            {
                Console.WriteLine("1: Nhap thong tin sinh vien - 2: thoat");
                int key = int.Parse(Console.ReadLine());
                if (key == 1)
                {
                    Sinhvien s = NhapSinhVien();
                    lsv.addSinhVien(s);
                }
                else if (key == 2)
                    break;
            }
            while (true);
            Console.WriteLine("Nhap ma lop can tim: ");
            string malop = Console.ReadLine();
            lsv.timKiemSinhvien(malop);
            //lsv.hienThi();
        }
    }

    internal struct Sinhvien
    {
        public string MaSinhVien;
        public string TenSinhvien;
        public int Namsinh;
        public string Lop;
    }

    internal class NodeSV
    {
        public NodeSV pNext;
        public Sinhvien info;
    }

    internal class ListSV
    {
        public NodeSV Head, Tail;

        public ListSV()
        {
            Head = Tail = null;
        }

        public NodeSV createNode(Sinhvien sv)
        {
            NodeSV nodeSv = new NodeSV();
            nodeSv.info = sv;
            nodeSv.pNext = null;
            return nodeSv;
        }

        public void addSinhVien(Sinhvien sv)
        {
            NodeSV nsv = createNode(sv);
            if (Head == null)
                Head = Tail = nsv;
            else
            {
                Tail.pNext = nsv;
                Tail = nsv;
            }
        }

        public void timKiemSinhvien(string lop)
        {
            NodeSV nsv = Head;
            List<NodeSV> listSv = new List<NodeSV>();
            while (nsv != null)
            {
                if (nsv.info.Lop == lop)
                    listSv.Add(nsv);
                nsv = nsv.pNext;
            }
            foreach (NodeSV n in listSv)
            {
                Console.WriteLine(n.info.TenSinhvien);
            }
        }

        public void hienThi()
        {
            NodeSV nsv = Head;
            while (nsv != null)
            {
                Console.WriteLine(nsv.info.TenSinhvien);
                nsv = nsv.pNext;
            }
        }
    }
}