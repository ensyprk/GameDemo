using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.concrete
{
    public class ActionGames : BaseGameManager, IGameService
    {
        public string gameName;
        public void Add()
        {
            Console.WriteLine("Action Game Added Library");
        }

        public void Remove()
        {
            Console.WriteLine("Action Game removed");
        }

        public void Sale(Gamer gamer)
        {
            Console.WriteLine("Action game purchased"+gamer.Name);
        }


        public void Update()
        {
            Console.WriteLine( "Action game updated" );
        }
    }
}
