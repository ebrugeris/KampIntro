using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameDemo.Entities;

namespace GameDemo.Abstract
{
    public interface IGameService
    {
        void Sale(Game game, Gamer gamer, Campaign campaign);
        void Add(Game game);
    }
}
