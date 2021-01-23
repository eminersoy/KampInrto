using System;
using System.Collections.Generic;     //aşağıya List eklediğimizde çalışması için bu olmalı

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];        //new yeni referans adresi (heap) demek new dediğimizde 5 elemanlı boş bir dizi oluşturduk. artık eski dizideki elemanlar gitti
            //isimler[4] = "İlker";           //yeni dizinin 5. elemanı ilker oldu ama diğer elemanlar boş kaldı
            //Console.WriteLine(isimler[4]);  //ilker yazar
            //Console.WriteLine(isimler[0]);  //boşluk çıkar bişey yazmaz
                                     //burası heap ten adres alma :)
            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil"};   // List i kullanabilmek için 2 satırar System.Collections.Generic ekledik
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("ilker");  // isimler2 ye ilkeri ekledik  .Add List in özelliğinden
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
           


        }
    }
}
