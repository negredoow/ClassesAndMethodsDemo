using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAndMethodsDemo
{
    public class MusteriManagerr
    {
        public void Ekle(int id, string ad, string soyad, string hesaptürü, bool cinsiyet)
        {

            List<Musteri> musteriListesi = new List<Musteri>();
            musteriListesi.Add(new Musteri(id, ad, soyad, hesaptürü, cinsiyet));
            Console.WriteLine("{0} {1} Adlı Kişi Eklendi", ad, soyad);
        }

        public void Sil()
        {
            Console.Write("Silinecek Kişinin Id Numarasını Giriniz :");
            int x = Convert.ToInt32(Console.ReadLine());

            List<Musteri> musteriListesi = new List<Musteri>();
            musteriListesi.RemoveAt(x);
            Console.WriteLine("{0} Numaralı Kayıt Silindi", x);
            Console.ReadLine();

        }

        public void Listele()
        {
            List<Musteri> musteriListesi = new List<Musteri>();
            musteriListesi.ForEach(musteriListe => Console.WriteLine(musteriListe.ToString()));
        }

    }
}
