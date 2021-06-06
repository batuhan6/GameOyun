using GameOyun.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameOyun.Abstract
{
    interface IGameSaleService
    {
        void Sale(Gamer gamer, Game game, Campaigns campaign);
    }
}
