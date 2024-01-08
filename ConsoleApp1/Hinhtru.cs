using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Hinhtru : Hinhtron
    {
        private double chieuCao;
      public Hinhtru()
        {
            this.chieuCao = double.Parse(Console.ReadLine());
        }
        public Hinhtru(double bankinh, double chieuCao):base(chieuCao)
        {
            this.chieuCao = chieuCao;
        }
        public void setChieuCao(double chieuCao)
        {
            this.chieuCao = chieuCao;
        }
        public double getChieuCao()
        {
            return chieuCao;
        }
        public double tinhDienTich()
        {
            return 2 * base.tinhDienTich() + tinhChuVi() * chieuCao;
        }
        public double tinhTheTich()
        {
            return base.tinhDienTich() * chieuCao;
        }
    }
}
