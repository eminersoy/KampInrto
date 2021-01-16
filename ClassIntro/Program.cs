using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Emin";   // string tipinde bir veri
            int yas = 35;          // int tipinde bir veri

            Kurs kurs1 = new Kurs();    // kurs tipinde bir veri
            kurs1.KursAdi = "C#";       // buralarda tanımladığımız değişkenin özelliklerini belirledik
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.izlenmeOrani = 65;

            Kurs kurs2 = new Kurs();    // kurs tipinde bir veri
            kurs2.KursAdi = "java";       // buralarda tanımladığımız değişkenin özelliklerini belirledik
            kurs2.Egitmen = "Kerem Varış";
            kurs2.izlenmeOrani = 45;

            Kurs kurs3 = new Kurs();    // kurs tipinde bir veri
            kurs3.KursAdi = "Phyton";       // buralarda tanımladığımız değişkenin özelliklerini belirledik
            kurs3.Egitmen = "Berkay Bilgili";
            kurs3.izlenmeOrani = 80;

            Kurs kurs4 = new Kurs();    // kurs tipinde bir veri
            kurs4.KursAdi = "C++";       // buralarda tanımladığımız değişkenin özelliklerini belirledik
            kurs4.Egitmen = "Murat Kurtboğan";
            kurs4.izlenmeOrani = 100;

                //bu veriler veritabanından gelir biz sadece aşağısıyla uğraşıcaz


            //Console.WriteLine(kurs1.KursAdi+ " " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3, kurs4 };    //kurs tipinde dizi oluşturduk

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }

        }
    }

    class Kurs             // burda int gibi string gibi değişken (veri tipi) tanımladık tipini biz belirledik birden fazla özellik içerebilir
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int izlenmeOrani { get; set; }
    }
}
