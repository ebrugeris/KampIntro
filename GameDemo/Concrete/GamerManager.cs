using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameDemo.Abstract;
using GameDemo.Entities;

namespace GameDemo.Concrete
{
    public class GamerManager : IGamerService, ICheckUserService
    {
        public bool CheckUser(Gamer gamer)
        {
            return true;
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("{0} Deleted from db", gamer.FirstName);
        }
        public void Save(Gamer gamer)
        {
            if (CheckUser(gamer))
            {
                Console.WriteLine("{0} Saved to db", gamer.FirstName);
            }
            else
            {
                Console.WriteLine("Not a valid user");
            }
            
        }
        public void Update(Gamer gamer, string NewName)
        {
            Console.WriteLine("{0} Updated as {1}", gamer.FirstName, NewName);
        }
    }
}
