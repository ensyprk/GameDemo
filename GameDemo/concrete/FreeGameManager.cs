using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.concrete
{
    internal class FreeGameManager : BaseGameManager, ICampaignManager
    {
       

        public void CampaignAdd(BaseGameManager baseGamemanager)
        {
            Console.WriteLine("Campaign added to : " + baseGamemanager.gameName);       }

        public void CampaignRemove()
        {
            Console.WriteLine("Free game removed");
        }

        public void CampaignUpdate()
        {
            Console.WriteLine("Free game updated");
        }
    }
}
