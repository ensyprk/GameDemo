using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Abstract
{
    internal interface ICampaignManager
    {
        
        void CampaignAdd(BaseGameManager baseGamemanager);
        void CampaignRemove();      
        void CampaignUpdate();
    }
}
