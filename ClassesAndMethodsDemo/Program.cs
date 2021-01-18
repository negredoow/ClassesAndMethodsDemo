using System;
using System.Collections.Generic;

namespace ClassesAndMethodsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri(1, "Ahmet", "Kara", "Vadeli", true);
            Musteri musteri2 = new Musteri(2, "Derya", "Deniz", "Vadesiz", false);
            Musteri musteri3 = new Musteri(3, "Abdullah", "Koç", "Vadeli", true);
            Musteri musteri4 = new Musteri(4, "Nesuf", "Koç", "Vadeli", true);
            Musteri musteri5 = new Musteri(5, "Kemal", "Gece", "Vadesiz", true);

            MusteriManagerr musteriManager = new MusteriManagerr();
            musteriManager.Ekle(musteri1.Id, musteri1.Ad, musteri1.Soyad, musteri1.HesapTuru, musteri1.Cinsiyet);
            musteriManager.Ekle(musteri2.Id, musteri2.Ad, musteri2.Soyad, musteri2.HesapTuru, musteri2.Cinsiyet);
            musteriManager.Ekle(musteri3.Id, musteri3.Ad, musteri3.Soyad, musteri3.HesapTuru, musteri3.Cinsiyet);
            musteriManager.Ekle(musteri4.Id, musteri4.Ad, musteri4.Soyad, musteri4.HesapTuru, musteri4.Cinsiyet);
            musteriManager.Ekle(musteri5.Id, musteri5.Ad, musteri5.Soyad, musteri5.HesapTuru, musteri5.Cinsiyet);
            List<Musteri> musteriListesi = new List<Musteri>()
            {

                musteri1,musteri2,musteri3,musteri4,musteri5



            };

            musteriListesi.ForEach(musteriListe => Console.WriteLine(musteriListe.ToString()));

            Console.Write("Silinecek Musterinin Id sini Giriniz : ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} Id Numaralı Kayıt Silindi", id);
            Console.ReadLine();

            musteriListesi.RemoveAt(id);
            musteriManager.Listele();

        }
    }
}
