using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 12345;
            musteri1.adi = "Çağan";
            musteri1.soyadi = "Demir";
            musteri1.tcNo = 123456;
            musteri1.Sehir = "Kocaeli";
            musteri1.kartCesiti = "Master";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 12346;
            musteri2.adi = "Çınar";
            musteri2.soyadi = "Demir";
            musteri2.tcNo = 112233;  // tc nolar string ile tutulur demişti hoca ama ben tutamadım o yüzden normal sayı gibi yazdım :)
            musteri2.Sehir = "Ankara";
            musteri2.kartCesiti = "Visa";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.adi);
                Console.WriteLine(musteri.soyadi);
                Console.WriteLine(musteri.tcNo);
                Console.WriteLine(musteri.Sehir);
                Console.WriteLine(musteri.kartCesiti);
                Console.WriteLine("------------------");
            }


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            Console.WriteLine("Musteri kaydı silme...");
            musteriManager.Ekle2(musteri1);
            musteriManager.Ekle2(musteri2);
        }
    }
}
