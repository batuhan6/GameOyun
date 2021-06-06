using GameOyun.Abstract;
using GameOyun.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameOyun.Concrete
{
    class GameSaleManager : IGameSaleService
    {
        public void Sale(Gamer gamer, Game game, Campaigns campaign)
        {
            double newPrice = game.GamePrice - (game.GamePrice * (campaign.CampaignDiscount / 100));
            Console.WriteLine(game.GameName + " oyunu " + gamer.FirstName + " " + gamer.LastName + " kişisine satıldı.");
            Console.WriteLine("Oyunun indirimli Fiyatı : " + newPrice + " TL");
            Console.WriteLine("Uygulanan İndirim fiyatı : " + game.GamePrice * (campaign.CampaignDiscount / 100) + " TL");
        }
    }
}
