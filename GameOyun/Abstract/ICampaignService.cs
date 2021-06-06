using System;
using GameOyun.Entities;
using System.Collections.Generic;
using System.Text;

namespace GameOyun.Abstract
{
    interface ICampaignService
    {
        void Add(Campaigns campaign);
        void Delete(Campaigns campaign);
        void Update(Campaigns campaign);
    }
}
