using GameDemo.Entities;
using GameDemo.Concrete;
namespace GameDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game1 = new Game() {Id=1, Name="Robots", Price= 150 };
            Game game2 = new Game() { Id = 2, Name = "Gta", Price = 600 };

            Gamer gamer1= new Gamer() {FirstName="Ebru", LastName="Yılmaz", NationalityId="34343434333", DateOfBirth= new DateTime(1990,4,13)};
            Gamer gamer2 = new Gamer() { FirstName = "Doğa", LastName = "Geriş", NationalityId = "22343434333", DateOfBirth = new DateTime(1995, 4, 13) };

            Campaign campaign1= new Campaign() {Name= "Summer Sales", Discount=13 };
            Campaign campaign2 = new Campaign() { Name = "Winter Sales", Discount = 15 };

            GameManager gameManager= new GameManager();
            gameManager.Add(game1);
            gameManager.Add(game2);
            gameManager.Sale(game1, gamer1, campaign1);
            gameManager.Sale(game2, gamer2, campaign2);

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Add(campaign2);

            GamerManager gamerManager= new GamerManager();
            gamerManager.Save(gamer1);
            gamerManager.Save(gamer2);
            gamerManager.Update(gamer1,"Elif");
            gamerManager.Delete(gamer2);




        }
    }
}