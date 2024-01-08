using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Hinhtron
    {
        private double bankinh; 
        public Hinhtron()
        {
            bankinh = double.Parse(Console.ReadLine());
        }
        public Hinhtron(double bankinh)
        {
            this.bankinh = bankinh;
        }
        public void setBanKinh(double bankinh)
        {
            this.bankinh = bankinh;
        }
        public double getBanKinh()
        {
            return bankinh;
        }
        public double tinhDienTich()
        {
            return bankinh * bankinh * Math.PI;
        }
        public double tinhChuVi()
        {
            return bankinh * 2 * Math.PI;
        }
    }

}
