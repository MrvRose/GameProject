using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IUserValidatioService userValidatioService;

        public GamerManager(IUserValidatioService userValidatioService)
        {
            this.userValidatioService = userValidatioService;
        }

        public void Add(Gamer gamer)
        {
            if(userValidatioService.Validate(gamer) == true)
            {
                Console.WriteLine("Kayıt Oluşturuldu");
            }
            else
            {
                Console.WriteLine("Dogrulama basarısız. Kayıt basarısız.");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt Silindi");
        }

        public void UpDate(Gamer gamer)
        {
            throw new NotImplementedException();
        }
    }
}
