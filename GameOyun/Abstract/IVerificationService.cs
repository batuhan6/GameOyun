using GameOyun.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameOyun.Abstract
{
    interface IVerificationService
    {
        bool CheckIfRealPerson(Gamer gamer);
    }
}
