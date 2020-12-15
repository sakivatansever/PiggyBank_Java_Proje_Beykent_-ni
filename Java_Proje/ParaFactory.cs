using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Java_Proje
{
   static class ParaFactory
    {

        public static IPara ParaGetir(double miktar)
        {
            if (miktar <= 1)
            {
                return new BozukPara(miktar);

            }
            else
            {
                return new KagitPara(miktar);
            }

        }

    }
}
