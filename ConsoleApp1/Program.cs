using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;
namespace Baitap1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap ban kinh: ");
            double bankinh= double.Parse(Console.ReadLine());
            Hinhtron hinhTron = new Hinhtron(bankinh);
            Console.WriteLine("Thong tin hinh tron:");
            Console.WriteLine("Ban kinh: " + bankinh);
            Console.WriteLine("Dien tich: " + hinhTron.tinhDienTich());
            Console.WriteLine("Chu vi: " + hinhTron.tinhChuVi());
            
            Console.WriteLine("Nhap chieu cao hinh tru: ");
            double chieuCao = double.Parse(Console.ReadLine());
            Hinhtru hinhTru = new Hinhtru(bankinh, chieuCao);
            Console.WriteLine("Thong tin hinh tru:");
            Console.WriteLine("Ban kinh: " + bankinh);
            Console.WriteLine("Chieu cao: " + chieuCao);
            Console.WriteLine("Dien tich: " + hinhTru.tinhDienTich());
            Console.WriteLine("The tich: " + hinhTru.tinhTheTich());
            Console.ReadKey();
        }
    }
}
