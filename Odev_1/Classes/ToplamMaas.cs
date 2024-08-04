using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_1.Classes
{
    public class ToplamMaas
    {
        double sonuc = 0;
        public double ToplamMaasHesapla(double sayi1, double sayi2, double sayi3, double sayi4)
        {
            sonuc = sayi1 + sayi2 + sayi3 + sayi4;
            return sonuc;
        }
    }
}
