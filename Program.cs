using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap02
{
    class SanPham
    {
        private string ten;
        private double giaMua;
        public SanPham() { }
        public SanPham(string ten, double giaMua)
        {
            this.ten = ten;
            this.giaMua = giaMua;
        }
        public string Ten {
            get { return ten; }
            set { ten = value; }
        }
        public double GiaMua {
            get { return giaMua; }
            set {
                if (value >= 0)
                    giaMua = value;
            }
        }
        public virtual double TinhGiaBan()
        {
            return 0;
        }
        public virtual string InTenChiTiet()
        {
            return Ten;
        }
        public virtual void Nhap()
        {
            Console.Write("Nhap ten san pham: ");
            ten = Console.ReadLine();
            Console.Write("Gia Mua: ");
            giaMua = double.Parse(Console.ReadLine());
        }

    }
    class Socola : SanPham
    {
        private double loiNhuan;
        public Socola() : base() { }
        public Socola(string ten, double giaMua) : base(ten, giaMua)
        {
            loiNhuan = (float)GiaMua * 0.2;
        }
        public override double TinhGiaBan()
        {
            return GiaMua + loiNhuan;
        }
        public override string InTenChiTiet()
        {
            return Ten + " " + TinhGiaBan();
        }
        public override void Nhap()
        {
            base.Nhap();
            loiNhuan = (float)GiaMua * 0.2;
        }

    }
    class NuocUong : SanPham
    {
        private double loiNhuan;
        private double phiGiuLanh;
        public NuocUong() : base() { }
        public NuocUong(string ten, double giaMua) : base(ten, giaMua)
        {
            loiNhuan = (float)GiaMua * 0.15;
            phiGiuLanh = (float)GiaMua * 0.1;
        }
        public override double TinhGiaBan()
        {
            return GiaMua + loiNhuan + phiGiuLanh;
        }
        public override string InTenChiTiet()
        {
            return Ten + " - " + TinhGiaBan();
        }
        public override void Nhap()
        {
            base.Nhap();
            loiNhuan = (float)GiaMua * 0.15;
            phiGiuLanh = (float)GiaMua * 0.1;
        }
    }
    class QuanLySanPham
    {
        private string tenCH;
        private SanPham[] dssp;
        private int n;
        public QuanLySanPham()
        {
            tenCH = " Cua hang ban le";
            dssp = new SanPham[100];
            n = 0;
        }
        public QuanLySanPham(int size)
        {
            tenCH = " Cua hang ban le";
            dssp = new SanPham[size];
            n = 0;
        }
        public void Nhap()
        {
            int chon;
            SanPham sp;
            while (true) {
                Console.WriteLine("Them san pham Loai(1.BanhKeo/ 2.NuocUong): ");
                chon = int.Parse(Console.ReadLine());
                switch (chon) {
                    case 1:
                        sp = new Socola();
                        sp.Nhap();
                        dssp[n++] = sp;
                        break;
                    case 2:
                        sp = new NuocUong();
                        sp.Nhap();
                        dssp[n++] = sp;
                        break;
                }
                Console.Write("Ban co muon tiep tuc?(0.No!)");
                chon = int.Parse(Console.ReadLine());
                if (chon == 0)
                    break;
            }
        }
        public void InDanhSanhSP()
        {
            Console.WriteLine(" Ten cua hang: " + tenCH);
            Console.WriteLine(" Danh sach cac san pham: ");
            for (int i = 0; i < n; i++) {
                Console.WriteLine(dssp[i].InTenChiTiet());
            }
        }
    }
class Program
    {
        static void Main(string[] args)
        {
            QuanLySanPham ql = new QuanLySanPham();
            ql.Nhap();
            ql.InDanhSanhSP();
            Console.ReadLine();
        }
    
    }
}
