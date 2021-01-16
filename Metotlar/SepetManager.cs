using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        //syntax
        public void Ekle(Urun urun) //ilk Urun veri tipi. ekleye parametre girdik
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi! : " +  urun.Adi);  //burda yaptığımız değişikli Ekle nin kullanıldığı her yerde değişiklik yaptırır
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi! : " + urunAdi);
        }
    }
}
