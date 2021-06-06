﻿using GameOyun.Abstract;
using GameOyun.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameOyun.Concrete
{
    class GamerManager : IGamerService
    {
        public GamerManager()
        {

        }
        private IVerificationService verificationService;

        public GamerManager(IVerificationService verificationService)
        {
            this.verificationService = verificationService;
        }
        public void Add(Gamer gamer)
        {
            if (verificationService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine(gamer.FirstName + gamer.LastName + " adlı oyuncu eklendi.");
            }
            else
            {
                Console.WriteLine(" Bilgilerinizi tekrar kontrol ediniz.");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + gamer.LastName + " adlı oyuncu silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + gamer.LastName + " adlı oyuncunun bilgileri güncellendi.");
        }
    }
}
