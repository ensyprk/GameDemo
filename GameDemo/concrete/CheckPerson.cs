using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.concrete
{
    internal class CheckPerson
    {
        public void CheckIfRealPerson(Gamer gamer)
        {

            Console.WriteLine("Kullanıcı Doğrulandı "+gamer.Name);
        
        
        
        }
    }
}
