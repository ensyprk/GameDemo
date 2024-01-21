using GameDemo.Abstract;
using GameDemo.concrete;
using GameDemo.Entities;

namespace GameDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Gamer  gamer1 = new Gamer();
            gamer1.Name = "Enes";
            gamer1.Surname = "yaprak";
            gamer1.Id = 1;
            gamer1.BirthYear = 2003;

        Gamer gamer2 = new Gamer();
            gamer2.Name = "Esra";
            gamer2.Surname = "Yaprak";
            gamer2.Id = 2;
            gamer2.BirthYear=1998;

            CheckPerson checkPerson = new CheckPerson();    
            checkPerson.CheckIfRealPerson(gamer1);
            checkPerson.CheckIfRealPerson(gamer2);

            Console.WriteLine("\n----------------------\n");




            IGameService game1 = new HorrorGames();
            IGameService game2 = new CarGames();
            IGameService game3 = new ActionGames();

            game1.Sale(gamer1);             // for gamer1
            game1.Add();        
            game1.Update();
            game1.Remove();

            Console.WriteLine("\n-------------------------------\n");

            game2.Sale(gamer2);             // for gamer2
            game2.Add();
            game2.Update();
            game2.Remove();

            Console.WriteLine("\n-------------------------------\n");

            ICampaignManager discountCampaign = new DiscountCampaignManager();
            BaseGameManager baseGameManager = new CarGames();
            baseGameManager.gameName = "Forza Horizon";
            discountCampaign.CampaignAdd(baseGameManager );
        
        
        
        
        }





    }
}
