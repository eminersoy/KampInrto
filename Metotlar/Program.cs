using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            //c# type safe -- tip güvenli bir dildir bu yüzden foreach içinde Urun yazdı 
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("--------------------");
            }

            Console.WriteLine("-------Metodlar--------");

            //instance - bir class örneği oluşturma
            //encapsulation - ilişkilendirmede sorun yaşama
            SepetManager sepetManager = new SepetManager(); //
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 4);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12, 3);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 7);
        }
    }
}


//Dont repeat yourself - DRY - Clean Code - Best practice (doğru uygulama teknikleri)

