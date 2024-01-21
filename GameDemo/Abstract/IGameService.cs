using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Abstract
{
    public interface IGameService
    {

        void Add();
        void Remove();

        void Update();
        void Sale(Gamer gamer);
    }
}
