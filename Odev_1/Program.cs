// See https://aka.ms/new-console-template for more information
using Odev_1.Classes;
//bir şirketimiz 
//GenelMüdür  80000.0
//Mudur       60000.0
//Programci   40000.0
//Stajyer       5000.0

//bu şirketteki çalışanların toplam maaşların
//hesaplayıp ekrana nasıl yazdırırdınız.

Console.WriteLine("\nMerhaba\n");

GenelMudur gm = new GenelMudur();
gm.CalisanTipi = "Genel Müdür";
Mudur m = new Mudur();
m.CalisanTipi = "Müdür";
Programci p = new Programci();
p.CalisanTipi = "Programcı";
Stajyer s = new Stajyer();
s.CalisanTipi = "Stajyer";

Calisan calisan = new Calisan();
double m1 = calisan.Maaslar(gm.CalisanTipi);
double m2 = calisan.Maaslar(m.CalisanTipi);
double m3 = calisan.Maaslar(p.CalisanTipi);
double m4 = calisan.Maaslar(s.CalisanTipi);

ToplamMaas toplam = new ToplamMaas();
double toplamMaas = toplam.ToplamMaasHesapla(m1,m2,m3,m4);
Console.WriteLine("Şirket içi Toplam Maaş : " + toplamMaas + " TL");