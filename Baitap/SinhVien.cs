using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap
{
    internal class SinhVien : Nguoi
    {
        int mahs;
        string tenhs;
        int namsinh;
        string diachi;
        double diemtoan, diemvan, diemanh, dtb;
        public SinhVien()
        {

        }
        public SinhVien(int ma, string ten, int ns, string dc)
        {
            mahs = ma;
            tenhs = ten;
            namsinh = ns;
            diachi = dc;


        }
        public void nhaphs()
        {
            Console.Write("Nhap ma hs :");
            mahs = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap ten hs:");
            tenhs = Console.ReadLine();
            NhapTT();
            Console.Write("Nhap nam sinh:");
            namsinh = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap dia chi:");
            diachi = Console.ReadLine();
            Console.Write("Nhap diem toan :");
            diemtoan = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap diem van :");
            diemanh = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap diem anh :");
            diemvan = Convert.ToDouble(Console.ReadLine());

        }
        public Double tinhdtb()
        {
            dtb = Math.Round((diemtoan + diemanh + diemvan) / 3, 1);
            return dtb;
        }
        public void xuaths()
        {
            //Console.WriteLine("Thong tin hoc sinh:");
            Console.WriteLine("Ma hs:" + mahs);
            Console.WriteLine("Ten:" + tenhs);
            XuatTT();
            Console.WriteLine("Nam sinh:" + namsinh);
            Console.WriteLine("Dia chi:" + diachi);
            Console.WriteLine("Diem Trung binh:" + dtb);
        }
    }
}