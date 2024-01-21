using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.concrete
{
    public class CarGames : BaseGameManager,IGameService
    {
        public string gameName;

        

        public void Add()
        {
            Console.WriteLine("Car Game saved library");   
                }

        public void Remove()
        {
            Console.WriteLine("Car Game removed"); 
                }

      

        public void Sale(Gamer gamer)
        {
            Console.WriteLine("Game purhased from : "+gamer.Name);        }

        public void Update()
        {
            Console.WriteLine("Car Game updated ");
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
