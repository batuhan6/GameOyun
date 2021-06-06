using GameOyun.Concrete;
using GameOyun.Entities;
using System;

namespace GameOyun
{
    class Program
    {
        static void Main(string[] args)
        {
            Campaigns d = new Campaigns();
            d.CampaignName = "SommerRabat";
            d.CampaignDiscount = 10;

            CampaignManager c = new CampaignManager();
            c.Add(d);
            Console.WriteLine("-----------------------");

            Game g = new Game();
            g.GameName = "Call of Duty";
            g.GamePrice = 20;
            g.GameCategory = "War";

            GameManager gm = new GameManager();
            gm.Add(g);
            Console.WriteLine("-----------------------");

            Gamer gamer1 = new Gamer
            {
                FirstName = "Engin ",
                LastName = "Demiroğ",
                NationalityId = "12345678910",
                DateOfBirth = new DateTime(1985, 1, 6)
            };

            GamerManager gamerManager = new GamerManager(new VerificationManager());
            gamerManager.Add(gamer1);
            Console.WriteLine("-----------------------");

            GameSaleManager gsm = new GameSaleManager();
            gsm.Sale(gamer1,g,d);
        }
    }
}
