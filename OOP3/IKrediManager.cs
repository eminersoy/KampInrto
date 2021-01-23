using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //class KrediManager
    //{
    //    public void Hesapla()                 bu kısmı interfaceye çevirdik aşağıdaki oldu
    //    {                                     interfaceleri birbirinin alternatifi olan fakat kod içeriği farklı olan durumlar için kullanırız
                                              //kredi türlerinin hepsinde hesaplama var fakat hesaplama şekilleri farklı.     
    //    }                                     örneğin log lama da böyledir. veri tabanına yazma, dosyaya yazma, sms - mail gönderme..
    //}

    interface IKrediManager
    {
        void Hesapla();
        void BiseyYap();

    }
}
