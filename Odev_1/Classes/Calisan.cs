using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_1.Classes
{
    public class Calisan 
    {
        public string Ad { get; set; } //özelleştirmek istersek hangi çalışantipi o zaman kullanabiliriz ikisini de
        public string Soyad { get; set; }
        public string CalisanTipi { get; set; }
        public double Maas { get; set; }

        public double Maaslar(string calisanTipi)
        {
            Console.WriteLine($"{calisanTipi} maaşı ne kadardır?");
            Maas = Convert.ToDouble(Console.ReadLine());
            return Maas;
        }

    }
}
