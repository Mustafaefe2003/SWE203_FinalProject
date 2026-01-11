using System;

namespace SWE203_FinalProject
{
    public class Araba
    {
        public string Plaka { get; set; }
        public int UretimYili { get; set; }
        private double _fiyat;

        // Hocanın istediği: Yaş hesaplaması (Age property)
        public int Yas => DateTime.Now.Year - UretimYili;

        public double GunlukFiyat
        {
            get { return _fiyat; }
            set
            {
                // Fiyat eksi girilirse 500 yap (Hatalı veri kontrolü)
                if (value > 0) _fiyat = value;
                else _fiyat = 500;
            }
        }
        public bool UygunMu { get; set; } = true;
    }
}
