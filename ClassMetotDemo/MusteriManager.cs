using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri ekle)
        {
            Console.WriteLine("Müşteri Eklendi: " + ekle.Adi+ " " + ekle.Soyadi);

        }
        public void MusteriSil(Musteri sil)
        {
            Console.WriteLine("Müşteri Silindi: " + sil.Adi+ " " + sil.Soyadi);
        }
        public void MusteriListele(Musteri[] liste)
        {
            Console.WriteLine("Müşteri listesi...");
            foreach (Musteri  mtr in liste)
            {
                Console.WriteLine("Id: " + mtr.id);
                Console.WriteLine("Adi: " + mtr.Adi);
                Console.WriteLine("Soyadi: " + mtr.Soyadi);
                Console.WriteLine("Tel: " + mtr.MusteriTel);
            }
        }
    }
}
