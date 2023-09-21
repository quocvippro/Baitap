using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace Baitap
{
    internal class Nguoi
    {
        public int SDT { get; set; }
        public String Gioitinh { get; set; }

        public Nguoi()
        {

        }
        public Nguoi(int sdt, string gt)
        {
            SDT = sdt;
            Gioitinh = gt;
        }
        public void NhapTT()
        {
            Console.Write("Nhap SDT: ");
            SDT = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap Gioi tinh :");
            Gioitinh = Console.ReadLine();

        }
        public void XuatTT()
        {
            Console.WriteLine("SDT:" + SDT);
            Console.WriteLine("Gioi Tinh:" + Gioitinh);
        }
    }

}