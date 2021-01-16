using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım geliştirici yetiştirme kursu";
            string kurs2 = "programlamaya başlangıç kursu";
            string kurs3 = "java kursu";
            string kurs4 = "phyton";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine("--------------manuel yazımın sonu");



            //array-dizi


            string[] kurslar = new string[] { "yazılım geliştirici yetiştirme kursu" , "programlamaya başlangıç kursu" , "java kursu","phyton", "c#" };


            for (int i = 0; i <3; i++) //buradaki döngü statik sadece 3 tekrar yapar yeni eklemeler dahil olmaz
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("--------------------statik döngünün sonu");


            for (int i = 0; i < kurslar.Length; i++) // burdaki döngü dinamik diziye ekleme yapılsa da çalışır
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("--------------------dinamik döngünün sonu");


            foreach (string kurs in kurslar)  //foreach dizileri kolay dolaşmak için kullanılır burada kurs alias herhangi bişey olabilir
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("-----------foreach li dinamik döngü sonu");
            Console.WriteLine("-----------sayfa sonu");
        }
    }
}
