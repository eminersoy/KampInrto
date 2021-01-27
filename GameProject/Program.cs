using System;

namespace GameProject // 5. günün 5. ödevi 6. günde ödevin bu kadarını birlikte yaptık gerisini tamamla!!!
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
           // GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager()); yeni edevlet doğrulamasına geçilirse yukardaki yerine bu kullanılır.
            gamerManager.Add(new Gamer { Id = 1, BirthYear = 1985, FirstName = "ENGİN", LastName = "DEMİROĞ", IdentityNumber = 12345 });

            Console.WriteLine("Hello World!");
        }
    }
}
