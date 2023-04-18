using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class UserValidationManager : IUserValidatioService
    {
        public bool Validate(Gamer gamer)
        {
            if(gamer.Birthday == 1985 && gamer.fir
                =="Engin" && gamer.LastName == "Demir" && gamer.IdentityNumber = 12345)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
