using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Induvidual
    class GercekMusteri: Musteri // inheritance (miras) Gercek müşteri bir müşteridir demek.Gerçek Müşteri  müsterinin özelliklerine de sahiptir
    {
       
        public string TcNo { get; set; } //üzerinde işlem yapılmayacak sayısal bilgileri string olarak tanımlamak daha iyidir
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
