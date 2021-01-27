using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    // MicroService: kimlik doğrulama için GamerManager in içinde başka bir servis kullanıyoruz.
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService; // bu şekilde yapma sebebimiz ileriki dönemde doğrulama servisinde değişiklik olursa sorun yaşamamak için

        public GamerManager(IUserValidationService userValidationService) //bu gamer manager içinde bir doğrulama sistemi kullanıcaz demek (ama gerçeği değil simüle ettiğimiz)
        {
            _userValidationService = userValidationService;
        }
        //constructor dan bu işlemi yaptık
        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true) 
            {
                Console.WriteLine("Kayıt oldu.");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız. Kayıt başarısız.");
            }

            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi.");
        }
    }
}
