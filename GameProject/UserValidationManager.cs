using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1984 && gamer.FirstName == "ENES" && gamer.LastName == "BORA" 
                && gamer.IdentityNumber == 12607745192)
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
