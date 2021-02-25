using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Adı : " + musteri.Ad);
            Console.WriteLine("Müşteri Soyadı : " + musteri.Soyad);
            Console.WriteLine("Müşteri Id : " + musteri.Id);
            Console.WriteLine("Müşteri Cinsiyeti : " + musteri.Cinsiyeti);
            Console.WriteLine("---------Müşteri Eklendi-----------");
        }

        
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Müşteri Adı : " + musteri.Ad);
            Console.WriteLine("Müşteri Soyadı : " + musteri.Soyad);
            Console.WriteLine("--------------Müşteri Listelendi--------------");
        }

       
        public void Silme(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " ----- " +"Adlı Müşteri Silindi!");
            Console.WriteLine("----------------------------------------------------");
        }

    }
}
