using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();  // bu satırın başına başlangıçta IhtiyacKrediManager yazmıştık
            //ihtiyacKrediManager.Hesapla();                                  // interfaceler de o interface i implemente eden classın referans numarasını tutabilir

            IKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            IKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            //IKrediManager esnafKrediManager = new EsnafKredisiManager();  bu satırı yazmak yerine aşağıda new ledik.


            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            //ILoggerService smsLoggerService = new SmsLoggerService();    bu satırı yazmak yerine aşağıda new ledik.

            List<ILoggerService> loggers = new List<ILoggerService> {new SmsLoggerService(), new FileLoggerService() };


            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(new EsnafKredisiManager(), new List<ILoggerService> { new DatabaseLoggerService(), new SmsLoggerService()} );  //yukarıda bi esnaf kredisi intance ı da oluşturulabilir. onun yerine burda new dedik

            basvuruManager.BasvuruYap(new EsnafKredisiManager(), loggers );

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);



        }
    }
}
