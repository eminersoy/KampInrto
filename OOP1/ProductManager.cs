using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public  void Add(Product product)   //burdaki Product puruduct için açıklama public  void Add(string isim) gibi bana Product tipinde bir veri gönder ben onu product ismiyle tutuyor olacağım
        {
            Console.WriteLine(product.ProductName+" eklendi"); 
        }

        //public void BiseyYap(int sayi)
        //{
        //    sayi = 99;
        //}

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName+" güncellendi");
        }


        //burdan sonrası void ve return anlatımı

        //public int Topla(int sayi1, int sayi2) // void yerine int kullanılması programın akışında burda elde edilen değerin tekrar kullanılması gerektiğinde uygun
        //{
        //    return sayi1 + sayi2;
        //}

        //public void Topla2(int sayi1, int sayi2) // void kullanılması elde edilen sonuç tekrar kullanılmadığında uygun. yani fonksiyon işini yapsın gitsin
        //{
        //    Console.WriteLine(sayi1 + sayi2);
        //}
    }



}
