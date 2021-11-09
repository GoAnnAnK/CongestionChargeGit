using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CongestionChargeGit.Calculations;
using CongestionChargeGit.Contracts.Enums;
using CongestionChargeGit.Persistence.Models;

namespace CongestionChargeGit
{
    public class CongestionCharge
    {
        IList<Transport> Items;

        public CongestionCharge(IList<Transport> transportList)
        {
            this.Items = transportList;
        }
        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                if (Items[i].TransportType == "Motorbike")
                {
                   new CalculateBikeFee(); 
                }
                if (Items[i].TransportType == "Car")
                {
                    new CalculateCarFee();
                }
                if (Items[i].TransportType == "Van")
                {
                    new CalculateVanFee();
                }
            }
        }
    }
}
