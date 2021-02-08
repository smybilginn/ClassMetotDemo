using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Sümeyye";
            musteri1.Soyad = "BİLGİN";


            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Ezgi";
            musteri2.Soyad = "BİLGİN";
            musteri2.Id = 2;
            

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "Müfide";
            musteri3.Soyad = "CAN";
           

            Musteri[] musteriler = new Musteri[] {musteri1,musteri2,musteri3 };

            MusteriManager musteriManager = new MusteriManager();
            
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);

            musteriManager.MusteriSil(musteri1);

            Console.WriteLine("Müşteri Listesi");
            musteriManager.MusteriListele(musteriler);
        }
    }
}
