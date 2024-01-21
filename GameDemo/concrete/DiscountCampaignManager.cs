using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.concrete
{
    internal class DiscountCampaignManager : BaseGameManager, ICampaignManager
    {

        

        public void CampaignAdd(BaseGameManager baseGamemanager)
        {
            Console.WriteLine("Campaign added to : " + baseGamemanager.gameName);
        }
    

    public void CampaignRemove()
        {
            Console.WriteLine( "Discount Removed" );        }

        public void CampaignUpdate()
        {
            Console.WriteLine("Campaign changed");
        }
    }
}
