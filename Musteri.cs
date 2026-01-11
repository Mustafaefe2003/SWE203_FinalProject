using System;

namespace SWE203_FinalProject
{
    public class Musteri
    {
        public string AdSoyad { get; set; }
        private int _ehliyetYili;

        public int EhliyetYili
        {
            get { return _ehliyetYili; }
            set
            {
                // Ehliyet yılı saçma bir tarih olmasın diye kontrol
                if (value <= DateTime.Now.Year && value > 1950) _ehliyetYili = value;
                else _ehliyetYili = DateTime.Now.Year;
            }
        }
        // Kaç yıllık tecrübesi olduğunu sistem saatinden hesaplıyoruz
        public int Tecrube => DateTime.Now.Year - _ehliyetYili;
    }
}