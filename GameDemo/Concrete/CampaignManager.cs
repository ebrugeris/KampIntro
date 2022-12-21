using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    internal class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("{0} added to db", campaign.Name);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("{0} deleted from db", campaign.Name);
        }

        public void Update(Campaign campaign, int NewDiscount)
        {
            Console.WriteLine("{0} is updated to {1}", campaign.Name, campaign.Discount);
        }
    }
}
