using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Coorporate
    class TuzelMusteri: Musteri  // inheritance (miras) Tuzel müşteri bir müşteridir demek.Tüzel Müşteri  müsterinin özelliklerine de sahiptir
    {
        
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
