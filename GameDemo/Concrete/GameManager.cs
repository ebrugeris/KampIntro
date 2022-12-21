using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.Name+ " saved to db");
        }

        public void Sale(Game game, Gamer gamer, Campaign campaign)
        {
            if (campaign.Discount==0)
            {
                Console.WriteLine("{0} game is sold to {1}",game.Name, gamer.FirstName);
            }
            else
            {
                Console.WriteLine("{0} is sold to {1} with {2} discount", game.Name, gamer.FirstName, campaign.Discount);
            }
        }
    }
}
