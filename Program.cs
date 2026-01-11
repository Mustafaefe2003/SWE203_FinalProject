using System;

namespace SWE203_FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Önce arabamızı tanımlıyoruz
            Araba benimAraba = new Araba();
            benimAraba.Plaka = "01 EFE 22"; 
            benimAraba.UretimYili = 2021;
            benimAraba.GunlukFiyat = 1250.0;

            // 2. Müşteriyi tanımlıyoruz
            Musteri eleman = new Musteri();
            eleman.AdSoyad = "Mehmet Tut"; 
            eleman.EhliyetYili = 2018;

            // 3. KiralamaServisi'ni kullanarak işlemi yapıyoruz
            KiralamaServisi servis = new KiralamaServisi();

            // Elemana, benim arabayı 4 günlüğüne kiralatıyoruz
            servis.KiralamayiBaslat(eleman, benimAraba, 4);

            // Ekranın hemen kapanmaması için
            Console.WriteLine("\nCikmak icin bir tusa bas aga...");
            Console.ReadKey();
        }
    }
}