using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAndMethodsDemo
{
    public class Musteri
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string HesapTuru { get; set; }

        public bool Cinsiyet { get; set; }

        public Musteri(int id, string ad, string soyad, string hesaptürü, bool cinsiyet = true)
        {
            this.Id = id;
            this.Ad = ad;
            this.Soyad = soyad;
            this.HesapTuru = hesaptürü;
            this.Cinsiyet = cinsiyet;
        }



        public override String ToString() => string.Format("{0,10} {1,10} {2,10} {3,10} {4,10}",
            Id, Ad, Soyad, HesapTuru, Cinsiyet == true ? "Erkek" : "Kadın");
    }
}
