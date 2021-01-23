using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1; 
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Emin";
            musteri1.Soyadi = "Ersoy";
            musteri1.TcNo = "22222233334";
           

            //Kodlama.io

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";


            //Gerçek müşteri - Tüzel Müşteri
            //SOLID
                                   // ref. no oluşturur
            Musteri musteri3 = new GercekMusteri(); //Musteri class ı hem gerçek hem tüzel kişinin referansını tutar
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);


               
        }
    }
}
