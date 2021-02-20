using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Hasan";
            musteri1.Soyad = "Özdişçi";
            musteri1.Id = "111111";
            musteri1.Yası = 23;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Melis";
            musteri2.Soyad = "Çakar";
            musteri2.Id = "111111";
            musteri2.Yası = 23;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Ad);
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Soyad);
                Console.WriteLine(musteri.Yası);
            }
            MusteriManager musterimanager = new MusteriManager();
            musterimanager.Ekle(musteri1);
            musterimanager.Ekle(musteri2);

            musterimanager.Sil(musteri1);
            musterimanager.Sil(musteri2);
        }
    }
}
