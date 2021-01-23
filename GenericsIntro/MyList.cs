using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro // generic ler çalışılacak özel bir tip için hazırlanır. müşteri, product, ...
{
    class MyList<T>  //burda generic teki list benzeri bir kuralı kendimiz tanımlıyoruz. Değişkenini T olarak biz belirledik değişebilir.
    {
        T[] items; //önce bunu new leyerek bellekte yerini oluşturmalıyız
       //constructor
        public MyList()  // bunu ctor ile yaptık bu class ı new lersek bu otomatik çalışır
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length+1]; //burda new lediğimizde yeni referans numarası alır eskisini kaybetmemek için üstte geçici dizi oluşturduk
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;

        }
    }
}
