using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Abstract
{
    internal interface IGamerService
    {
        void Add(IGamerService game);

        void Update();

        void Remove();

    }
}
