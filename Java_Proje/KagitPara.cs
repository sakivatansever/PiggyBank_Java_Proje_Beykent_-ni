using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Java_Proje
{
    class KagitPara : IKatlanabilirlik, IPara
    {
        public double En { get ; set ; }
        public double Boy { get; set; }
        public double Yukseklik { get; set; }
        public double Miktar { get; set; }
        public double Hacim { get; set; }
        public double NormalHacim { get; set; }

        public KagitPara(double miktar)
        {
            switch (miktar)
            {
                case 5:
                    this.Miktar = 5;
                    this.En = 64;
                    this.Boy = 13;
                    this.Yukseklik = 0.25;
                    break;
                case 10:
                    this.Miktar = 10;
                    this.En = 64 ;
                    this.Boy = 136;
                    this.Yukseklik = 0.25;
                    break;
                case 20:
                    this.Miktar = 20;
                    this.En = 68 ;
                    this.Boy = 142 ;
                    this.Yukseklik = 0.25;
                    break;
                case 50:
                    this.Miktar = 50;
                    this.En = 68 ;
                    this.Boy = 148;
                    this.Yukseklik = 0.25;
                    break;
                case 100:
                    this.Miktar = 100;
                    this.En = 72;
                    this.Boy = 154;
                    this.Yukseklik = 0.25;
                    break;
                case 200:
                    this.Miktar = 200;
                    this.En = 72;
                    this.Boy = 160;
                    this.Yukseklik = 0.25;
                    break;
            }
            this.Katla();
            this.Hacim = this.NormalHacim;
        }

        public void Katla()
        {
            this.En = this.En / 4;
            this.Yukseklik = this.Yukseklik * 4;
            this.NormalHacim = En * Boy * Yukseklik;
        }
    }
}
