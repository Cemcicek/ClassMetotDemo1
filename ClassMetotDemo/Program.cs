using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.id = 1;
            musteri1.Adi = "Cem";
            musteri1.Soyadi = "Çiçek";
            musteri1.MusteriTel = 55555555;

            Musteri musteri2 = new Musteri();
            musteri2.id = 1;
            musteri2.Adi = "Emir";
            musteri2.Soyadi = "Çiçek";
            musteri2.MusteriTel = 55555555;

            MusteriManager musteriManager = new MusteriManager();
            Console.WriteLine("--Müşteri Ekleme--");
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            Console.WriteLine("---------------------------------");

            Console.WriteLine("--Müşteri Silme--");
            musteriManager.MusteriSil(musteri1);
            musteriManager.MusteriSil(musteri2);
            Console.WriteLine("---------------------------------");

            Console.WriteLine("--Müşteri Liteleme Metodu--");
            Musteri[] musteriliste = new Musteri[] { musteri1, musteri2 };
            musteriManager.MusteriListele(musteriliste);

            Console.ReadLine();
        }
    }
}
