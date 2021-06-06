using GameOyun.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameOyun.Abstract
{
    interface IGamerService
    {
        void Add(Gamer gamer);
        void Delete(Gamer gamer);
        void Update(Gamer gamer);
    }
}
