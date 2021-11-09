using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CongestionChargeGit.Contracts.Enums;
using CongestionChargeGit.Persistence.Models;

namespace CongestionChargeGit
{
    public class CongestionCharge
    {
        IList<Transport> transportList;

        public CongestionCharge(IList<Transport> transportList)
        {
            this.transportList = transportList;
        }
        public void UpdateQuality()
        {
            for (var i = 0; i < transportList.Count; i++)
            {
                if (transportList[i].TransportType == "Motorbike")
                {
                   new CalculateBikeFee(); 
                }
                if (transportList[i].TransportType == "Car")
                {
                    new CalculateCarFee();
                }
                if (transportList[i].TransportType == "Van")
                {
                    new CalculateVanFee();
                }
            }
        }
    }
}
