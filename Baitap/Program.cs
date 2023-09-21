using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Baitap
{
    internal class Program
    {



        static void Main(string[] args)
        {

            Console.Write("Nhap so luong sinh vien :");
            int n = Convert.ToInt32(Console.ReadLine());
            SinhVien[] dssv = new SinhVien[n];
            for (int i = 0; i < n; i++)
            {
                dssv[i] = new SinhVien();
                Console.WriteLine("Nhap Thong tin Sv " + (i + 1) + " :");
                dssv[i].nhaphs();
                dssv[i].tinhdtb();

            }

            /*  foreach (SinhVien sv in dssv) {
                 Console.WriteLine("Thong tin sinh vien");
                 sv.xuaths(); 
             } */

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Thong tin sv " + (i + 1));
                dssv[i].xuaths();

            }
            Console.ReadKey();
        }

    }

}