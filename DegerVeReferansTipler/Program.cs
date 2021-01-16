using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            // sayi1 ??    sayi1 değeri 30 dur

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0]  ??  999 olur
            
            // bu not önemli!!!
            // int, decimal, float, double, bool (0 ve 1) gibi sayısal görüntüde olan değişkenler "değer tip"
            // array, class, interface referans tip değişkenlerdi
            // değer tiplerinde değer referans tiplerde adres ataması yapılır
        }
    }
}
