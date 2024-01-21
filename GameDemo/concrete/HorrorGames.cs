using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.concrete
{
    public class HorrorGames :IGameService
    {
        
        public void Add()
        {
            Console.WriteLine("Horror Game saved library");         }

        public void Remove()
        {
            Console.WriteLine("Horror Game removed");
        }
        public string gameName;



        public void Sale(Gamer gamer)
        {
            Console.WriteLine("Horror Game purhased from :" + gamer.Name);
        }

        public void Update()
        {
            Console.WriteLine("Horror Game updated");
        }
    }
}
