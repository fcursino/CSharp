using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Cálculo_de_Média_MG_
{
    class ClassCalculo
    {
        public double media;
        public double Processar(double n1,double n2,double n3,double n4)
        {
            media = (n1 + n2 + n3 + n4) / 4;
            media = Math.Round(media, 2);
            return media;
        }
    }
}
