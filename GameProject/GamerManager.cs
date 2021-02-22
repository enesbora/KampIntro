using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    //MicroService
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Kayit oldu");
            }
            else
            {
                Console.WriteLine("Dogrulama basarisiz. Kayit basarisiz.");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayit silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayit güncellendi");
        }
    }
}
