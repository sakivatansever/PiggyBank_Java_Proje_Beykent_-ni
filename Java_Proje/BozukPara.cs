using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Java_Proje
{
    class BozukPara : IPara
    {
        public double En { get; set; }
        public double Boy { get; set; }
        public double Yukseklik { get; set; }
        public double Miktar { get; set; }
        public double Hacim { get; set; }
        public double NormalHacim { get; set; }
        const double Pi = 3.14;
        public BozukPara(double miktar)
        {
            switch (miktar)
            {
                case 0.01:
                    this.Miktar = 0.01;
                    this.En = 16.50 / 2;
                    this.Boy = 16.50 / 2;
                    this.Yukseklik = 0.25;
                    break;
                case 0.05:
                    this.Miktar = 0.05;
                    this.En = 17.50 / 2;
                    this.Boy = 17.50 / 2;
                    this.Yukseklik = 0.25;
                    break;
                case 0.10:
                    this.Miktar = 0.10;
                    this.En = 18.5 / 2;
                    this.Boy = 18.5 * 2;
                    this.Yukseklik = 0.25;
                    break;
                case 0.25:
                    this.Miktar = 0.25;
                    this.En = 20.5 / 2;
                    this.Boy = 20.5 / 2;
                    this.Yukseklik = 0.25;
                    break;
                case 0.50:
                    this.Miktar = 0.50;
                    this.En = 23.85 / 2;
                    this.Boy = 23.85 / 2;
                    this.Yukseklik = 0.25;
                    break;
                case 1:
                    this.Miktar = 1;
                    this.En = 26.15 / 2;
                    this.Boy = 26.15 / 2;
                    this.Yukseklik = 0.25;
                    break;
            }
            this.NormalHacim = this.En * this.Boy * Pi;
            this.Hacim = this.NormalHacim;
        }
    }
}
