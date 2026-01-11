using System;

namespace SWE203_FinalProject
{
    public class KiralamaServisi
    {
        // Bu metod ana motorumuz. Müşteriyi ve Arabayı alıp kontrol eder.
        public void KiralamayiBaslat(Musteri m, Araba a, int gun)
        {
            Console.WriteLine($"--- {a.Plaka} Plakali Arac Kontrol Ediliyor ---");

            // KURAL: Araba uygun olacak ve müşterinin ehliyeti en az 2 yıllık olacak
            if (a.UygunMu && m.Tecrube >= 2)
            {
                // İşlem başarılıysa aracın durumunu değiştiriyoruz
                a.UygunMu = false;
                double toplamBorc = a.GunlukFiyat * gun;

                Console.WriteLine("Islem Onaylandi!");
                Console.WriteLine($"Musteri: {m.AdSoyad}");
                Console.WriteLine($"Toplam Borc: {toplamBorc} TL");
            }
            else
            {
                // Eğer şartlar uymazsa nedenini yazdırıyoruz
                Console.WriteLine("Islem Reddedildi: Arac musait degil veya tecrubeniz yetersiz.");
            }
        }
    }
}