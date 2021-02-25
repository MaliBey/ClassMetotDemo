using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.Id = 3062;
            musteri1.Ad = "Hüsamettin";
            musteri1.Soyad = "Yılmaz";
            musteri1.Cinsiyeti = "Erkek";
            musteri1.Yasi = 38;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 1598;
            musteri2.Ad = "Şaziye";
            musteri2.Soyad = "Oğlak";
            musteri2.Cinsiyeti = "Kadın";
            musteri2.Yasi = 21;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 5936;
            musteri3.Ad = "Berkecan";
            musteri3.Soyad = "Turan";
            musteri3.Cinsiyeti = "Erkek";
            musteri3.Yasi = 69;

            Musteri musteri4 = new Musteri();
            musteri4.Id = 8642;
            musteri4.Ad = "Derya";
            musteri4.Soyad = "Kuzulu";
            musteri4.Cinsiyeti = "Kadın";
            musteri4.Yasi = 34;



            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri4);
            musteriManager.Silme(musteri3);
            musteriManager.Listele(musteri2);
            musteriManager.Ekle(musteri1);
           


        }
    }
}
