using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Tebrikler Kaydınız Tamamlanmıştır : " + musteri.adi + " " + musteri.soyadi);
            Console.WriteLine("Bankamıza Hoşgeldiniz");
        }

        public void Ekle2(Musteri musteri)
        {
            Console.WriteLine("Kaydınız Silinmiştir : " + musteri.adi + " " + musteri.soyadi);
            Console.WriteLine("Tekrar Çalışmak Ümidiyle");
        }

    }
}
