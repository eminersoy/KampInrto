using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer); //doğru yanlış şeklinde geri dönüş istediğimiz için void u bool yaptık

    }
}
