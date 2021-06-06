using GameOyun.Abstract;
using GameOyun.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameOyun.Concrete
{
    class VerificationManager : IVerificationService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            if (gamer.NationalityId.Length == 11)
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
