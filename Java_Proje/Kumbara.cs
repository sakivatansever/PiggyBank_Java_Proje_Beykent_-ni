using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Java_Proje
{
    class Kumbara
    {

        bool yapistirildiMi;
        public bool kirildiMi;
        List<IPara> Paralar = new List<IPara>();
        const long kumbaraHacmi = 20000;
        static Random rnd = new Random();

        public bool ParaEkle(double miktar)
        {
            double toplamHacim = Paralar.Sum(p => p.Hacim);

            if (!kirildiMi && toplamHacim < kumbaraHacmi)
            {
                IPara p = ParaFactory.ParaGetir(miktar);
                int randomHacim = rnd.Next(25, 75);
                p.Hacim = p.NormalHacim + (p.NormalHacim * randomHacim) / 100;
                Paralar.Add(p);
                return true;

            }

            else if (kirildiMi&&!yapistirildiMi)
            {
                HataMesajlari.KumbaraZatenKirik();
                return false;
            }
            


            else if (toplamHacim > kumbaraHacmi)
            {
                HataMesajlari.KumbaraDolu();
                return false;

            }
            else
            {
                return false;
            }

        }

        public void KumbarayiCalkala()
        {
            foreach (var para in Paralar)
            {
                para.Hacim = para.NormalHacim * 125 / 100;
            }

        }

        public double KumbarayiKir()
        {
            if (kirildiMi)
            {
                HataMesajlari.KumbaraZatenKirik();
            }
            double toplamMiktar = this.Paralar.Sum(p => p.Miktar);
            kirildiMi = true;
            return toplamMiktar;

        }

        public double dolulukOranı() {

           double toplamHacim= Paralar.Sum(p => p.Hacim);
            return toplamHacim * 100 / kumbaraHacmi;
        }

        public bool KumbarayiYapistir()
        {
            if (!yapistirildiMi && kirildiMi)
            {
                this.Paralar.Clear();
                yapistirildiMi = true;
                kirildiMi = false;
                return true;
            }
            else if (!kirildiMi)
            {
                if (!kirildiMi)
                { HataMesajlari.OnceKumbarayiKir();
                }
                return false;
            }
            else if (kirildiMi)
            {
                HataMesajlari.KumbaraZatenKirik();
                return false;
            }
            else
            {
                return false;
            }
        }
    }

}

